using Syncfusion.Pdf;
using Syncfusion.Pdf.Parsing;
using System.Diagnostics;
using System.Media;
using System.Runtime.CompilerServices;

namespace LMProg {
    public partial class Form1 : Form {

        public Form1() {
            InitializeComponent();

            //Listview settings
            listView1.Columns.Add("Sivu", 50, HorizontalAlignment.Left);
            listView1.Columns.Add("Tiedosto", -2, HorizontalAlignment.Left);
            listView1.View = View.Details;
            listView1.CheckBoxes = true;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Select();

            HandleInsertAfterBeforeButtonsState(filePathStringList.ToArray());
            HandleFileOperationsButtonsState();
            HandleRemoveButtonsState();

            PreviewButton.Text = "";
            PrintButton.Text = "";
            CreateFileButton.Text = "";
        }

        private bool textBoxTextHasChanged = false;

        static readonly string emptyPagePageNumberString = "Tyhj‰ sivu";
        static readonly string emptyPageFileNameString = "Tyhj‰ tiedostonimi";
        static readonly string emptyPageFilePathString = "Tyhj‰ tiedostopolku";
        static readonly string emptyPageIndexString = "-0";

        static readonly string[] emptyListViewItemStringArray = new string[] { emptyPagePageNumberString, emptyPageFileNameString, emptyPageFilePathString, emptyPageIndexString };

        private List<string> filePathStringList = new();
        //private string[] filePathStringArray;
        //private string filePathString = string.Empty;
        private PdfLoadedDocument? pdfLoadedDocument = null;
        //private PdfLoadedDocument[] pdfLoadedDocuments = null;

        private void FileSelectButton_Click(object sender, EventArgs e) {

            using OpenFileDialog openFileDialog = new();
            openFileDialog.Filter = "PDF tiedostot (*.pdf)|*.pdf";
            openFileDialog.Multiselect = true;

            //return if openFileDialog result is something other than "OK"
            if (openFileDialog.ShowDialog() != DialogResult.OK) { return; }

            filePathStringList = openFileDialog.FileNames.ToList();
            FileSelectTextBox.Text = string.Empty;
            foreach (string filePath in filePathStringList) {
                if (FileSelectTextBox.Text == string.Empty) {
                    FileSelectTextBox.Text += filePath;
                } else {
                    FileSelectTextBox.Text += Environment.NewLine + filePath;
                }
            }

            HandleInsertAfterBeforeButtonsState(filePathStringList.ToArray());
            FilePathErrorProviderHandler(filePathStringList.ToArray());
            HandleRemoveButtonsState();
        }

        private void FileSelectTextBox_TextChanged(object sender, EventArgs e) {
            textBoxTextHasChanged = true;
        }

        private void InsertBeforeButton_Click(object sender, EventArgs e) {
            //If File path is incorrect, play sound, show error and return.
            //if (!File.Exists(FileSelectTextBox.Text)) { SystemSounds.Asterisk.Play(); errorProvider1.SetError(FileSelectTextBox, "V‰‰r‰ tiedostopolku!"); return; }
            if (!CheckIfFilePathExists(filePathStringList.ToArray())) { return; }

            //If there are no selected items in the list, ask user to select an item.
            if (listView1.SelectedIndices.Count < 1) { SystemSounds.Asterisk.Play(); MessageBox.Show("Lis‰‰ ennen mit‰?"); return; }

            //Insert file name, page number and file path of currently loaded files into the list
            //BEFORE the selected item
            InsertFiles(listView1.SelectedIndices[0], sender);
            //HandleFileOperationsButtonsState();
            HandleRemoveButtonsState();
        }

        private void InsertAfterButton_Click(object sender, EventArgs e) {
            //If File path is incorrect, play sound, show error and return.
            //if (!File.Exists(FileSelectTextBox.Text)) { SystemSounds.Asterisk.Play(); errorProvider1.SetError(FileSelectTextBox, "V‰‰r‰ tiedostopolku!"); return; }
            if (!CheckIfFilePathExists(filePathStringList.ToArray())) { return; }

            //If there are no selected items in the list, ask user to select an item.
            if (listView1.SelectedIndices.Count < 1) { SystemSounds.Asterisk.Play(); MessageBox.Show("Lis‰‰ mink‰ j‰lkeen?"); return; }

            //Insert file name, page number and file path of currently loaded file into the list
            //AFTER the selected item
            InsertFiles(listView1.SelectedIndices[0] + 1, sender);
            //HandleFileOperationsButtonsState();
            HandleRemoveButtonsState();
        }

        private void InsertButton_Click(object sender, EventArgs e) {
            //If File path is incorrect, play sound, show error and return.
            //if (!File.Exists(FileSelectTextBox.Text)) { SystemSounds.Asterisk.Play(); errorProvider1.SetError(FileSelectTextBox, "V‰‰r‰ tiedostopolku!"); return; }
            if (!CheckIfFilePathExists(filePathStringList.ToArray())) { return; }

            //Does not care about the selected item.
            //Always adds items to the back of the list
            //Add file name, page number and filename  of currently loaded
            //file into the list as a ListViewItem
            //Selects the last item added.
            InsertFiles(listView1.Items.Count, sender);
            //HandleFileOperationsButtonsState();
            HandleRemoveButtonsState();
        }

        private void InsertEmptyBeforeButton_Click(object sender, EventArgs e) {
            int startIndex = listView1.SelectedIndices[0];
            listView1.Items.Insert(startIndex, new ListViewItem(emptyListViewItemStringArray));
            listView1.Items[startIndex].Checked = true;
            HandleRemoveButtonsState();
        }

        private void InsertEmptyAfterButton_Click(object sender, EventArgs e) {
            int startIndex = listView1.SelectedIndices[0] + 1;
            listView1.Items.Insert(startIndex, new ListViewItem(emptyListViewItemStringArray));
            listView1.Items[startIndex].Checked = true;
            HandleRemoveButtonsState();
        }

        private void InsertEmptyButton_Click(object sender, EventArgs e) {
            int startIndex = listView1.Items.Count;
            listView1.Items.Add(new ListViewItem(emptyListViewItemStringArray));
            listView1.Items[startIndex].Checked = true;
            HandleRemoveButtonsState();
        }



        private void RemoveSelectedButton_Click(object sender, EventArgs e) {
            if (listView1.Items.Count <= 0) { return; }
            var messageBoxResult = MessageBox.Show("Haluatko varmasti poistaa valitut sivut?", "Vahvistus", MessageBoxButtons.YesNo);
            if (messageBoxResult != DialogResult.Yes) { return; }


            int lastRemovedIndex = 0;
            //Go through all selected items on the list  and delete them.
            foreach (ListViewItem selectedItem in listView1.SelectedItems) {
                lastRemovedIndex = selectedItem.Index;
                listView1.Items.Remove(selectedItem);
            }

            //Select the next item on the list
            //If the list is empty, do not select anything
            //If the last selected item is at the end of the list,
            //select the item that would be at the end of the list.
            //Otherwise, select the item at the same index than the one removed.

            if (listView1.Items.Count > 0) {
                if (listView1.Items.Count - 1 < lastRemovedIndex) {
                    listView1.Items[lastRemovedIndex - 1].Selected = true;
                } else {
                    listView1.Items[lastRemovedIndex].Selected = true;
                }
            }
            HandleInsertAfterBeforeButtonsState(filePathStringList.ToArray());
            HandleFileOperationsButtonsState();
            HandleRemoveButtonsState();
        }

        private void RemoveAllButton_Click(object sender, EventArgs e) {
            //if (listView1.Items.Count <= 0) { return; }
            var messageBoxResult = MessageBox.Show("Haluatko varmasti poistaa kaikki sivut?", "Vahvistus", MessageBoxButtons.YesNo);
            if (messageBoxResult != DialogResult.Yes) { return; }

            listView1.Items.Clear();
            HandleInsertAfterBeforeButtonsState(filePathStringList.ToArray());
            HandleFileOperationsButtonsState();
            HandleRemoveButtonsState();
        }


        private void MoveItemUpButton(object sender, EventArgs e) {
            //Do nothing if there are no items in the list
            if (listView1.Items.Count <= 0) { return; }
            //If nothing is selected, select the first item on the list.
            if (listView1.SelectedIndices.Count <= 0) { listView1.Items[0].Selected = true; }

            //Suspend update for ListView during this operation.
            listView1.BeginUpdate(); //Does this even help at all?

            //Go through all of the selected items on the list
            for (int i = 0; i < listView1.SelectedIndices.Count; i++) {
                //If the current index of the item on the list is 0 or less, skip.
                //If the current index of the item on the list of selected items is
                //less than the current iteration count of the loop, skip.
                if (listView1.SelectedIndices[i] <= 0 || listView1.SelectedIndices[i] <= i) { continue; }

                //Make a temporary ListViewItem out of the item that's being currently moved.
                //Get the current index of the item being moved and substract one from it.
                //Remove the current item from the list.
                //Insert it into the list with a new index.
                ListViewItem tempListViewItem = listView1.Items[listView1.SelectedIndices[i]];
                int index = listView1.SelectedIndices[i] - 1;
                listView1.Items.Remove(tempListViewItem);
                listView1.Items.Insert(index, tempListViewItem);
            }
            listView1.EndUpdate();
        }

        private void MoveItemDownButton(object sender, EventArgs e) {
            //Do nothing if there are no items in the list
            if (listView1.Items.Count <= 0) { return; }
            //If nothing is selected, select the first item on the list.
            if (listView1.SelectedIndices.Count <= 0) { listView1.Items[0].Selected = true; }

            //Suspend update for ListView during this operation.
            listView1.BeginUpdate();

            //Make a variable for loop iteration
            int j = 0;
            for (int i = listView1.SelectedIndices.Count - 1; i >= 0; i--) {
                //If the current index of the item on the list is bigger or
                //the same as the index of the last item on the list, skip.
                //If the current index of the selected item on the list is bigger or
                //the same as the count of selected items substracted by one and
                //the iteration of the loop, skip
                if (listView1.SelectedIndices[i] >= listView1.Items.Count - 1 || listView1.SelectedIndices[i] >= listView1.Items.Count - 1 - j) { j++; continue; }

                ListViewItem tempListViewitem = listView1.Items[listView1.SelectedIndices[i]];
                int index = listView1.SelectedIndices[i] + 1;
                listView1.Items.Remove(tempListViewitem);
                listView1.Items.Insert(index, tempListViewitem);
                j++;
            }
            listView1.EndUpdate();
        }

        private void CreatePDFButton_Click(object sender, EventArgs e) {
            PdfDocument pdfCreatedDocument = new();
            pdfCreatedDocument.PageSettings.Size = PdfPageSize.A4;

            PdfLoadedDocument? pdfCreationLoadedDocument = null;

            string previousItemPath = string.Empty;

            foreach (ListViewItem item in listView1.Items) {
                //Check if item checked, if not, skip this iteration of the loop.
                if (!item.Checked) { continue; }
                //If item has more no subitems, skip this iteration of the loop
                //This should not happen during normal operation
                if (item.SubItems.Count <= 1) { continue; }

                if (item.SubItems[2].Text == emptyPageFilePathString) {
                    PdfPage page = new();
                    if (pdfCreatedDocument.Pages.Count > 0) {
                        pdfCreatedDocument.Pages.Insert(pdfCreatedDocument.Pages.Count - 1, page);
                    } else {
                        pdfCreatedDocument.Pages.Insert(0, page);
                    }

                } else {
                    if (item.SubItems[2].Text != previousItemPath) {
                        pdfCreationLoadedDocument = new(item.SubItems[2].Text);
                        previousItemPath = item.SubItems[2].Text;
                    }
                    PdfPageBase pdfPageBase = pdfCreationLoadedDocument.Pages[int.Parse(item.SubItems[3].Text)];
                    pdfPageBase = pdfCreatedDocument.Pages.Add();
                }
            }

            using SaveFileDialog saveFileDialog = new();
            saveFileDialog.Filter = "PDF tiedostot (*.pdf)|*.pdf";
            saveFileDialog.DefaultExt = ".pdf";
            saveFileDialog.FileName = "*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK) {
                pdfCreatedDocument.Save(saveFileDialog.FileName);
            }
            pdfCreatedDocument.Close(true);
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e) {
            HandleInsertAfterBeforeButtonsState(filePathStringList.ToArray());
            HandleRemoveButtonsState();
        }

        private static ListViewItem GenerateListViewItem(string pageNumber, string fileName, string filePath, string index) {
            ListViewItem listViewItem = new(new[] { pageNumber, fileName, filePath, index });
            return listViewItem;
        }

        private void HandleRemoveButtonsState() {
            if (listView1.SelectedIndices.Count > 0) {
                RemoveSelectedButton.Enabled = true;
            } else {
                RemoveSelectedButton.Enabled = false;
            }

            if (listView1.Items.Count > 0) {
                RemoveAllButton.Enabled = true;
            } else {
                RemoveAllButton.Enabled = false;
            }
        }

        private void HandleFileOperationsButtonsState() {
            if (listView1.CheckedItems.Count > 0) {
                CreatePDFButton.Enabled = true;
                //CreateFileButton.Enabled = true;
                //PreviewButton.Enabled = true;
                //PrintButton.Enabled = true;
            } else {
                CreatePDFButton.Enabled = false;
                //CreateFileButton.Enabled = false;
                //PreviewButton.Enabled = false;
                //PrintButton.Enabled = false;
            }
        }

        private void HandleInsertAfterBeforeButtonsState(string[] strings) {

            if (!CheckIfFilePathExists(strings)) {
                InsertButton.Enabled = false;
            } else {
                InsertButton.Enabled = true;
            }

            if (listView1.SelectedIndices.Count <= 0) {
                InsertEmptyAfterButton.Enabled = false;
                InsertEmptyBeforeButton.Enabled = false;
                InsertAfterButton.Enabled = false;
                InsertBeforeButton.Enabled = false;
                return;
            }

            if (CheckIfFilePathExists(strings)) {
                InsertAfterButton.Enabled = true;
                InsertBeforeButton.Enabled = true;
            }

            InsertEmptyAfterButton.Enabled = true;
            InsertEmptyBeforeButton.Enabled = true;
        }

        private void FileSelectTextBox_Enter(object sender, EventArgs e) {
            textBoxTextHasChanged = false;
        }

        private void FileSelectTextBox_Leave(object sender, EventArgs e) {

            //Add all lines back to the filePathStringList after clearing it.
            if (textBoxTextHasChanged) {
                filePathStringList.Clear();
                foreach (string textBoxLine in FileSelectTextBox.Text.Split(Environment.NewLine)) {  //new char[] { '\r', '\n' })) {
                    filePathStringList.Add(textBoxLine);
                }
                HandleInsertAfterBeforeButtonsState(filePathStringList.ToArray());
                FilePathErrorProviderHandler(filePathStringList.ToArray());
            }
        }

        private bool CheckIfFilePathExists(string[] strings) {
            if (strings.Length < 1) { return false; }
            if (string.IsNullOrEmpty(strings[0])) { return false; }

            foreach (string filePathString in strings) {
                if (!File.Exists(filePathString)) {
                    return false;
                }
            }
            return true;
        }

        private void FilePathErrorProviderHandler(string[] strings) {
            if (strings.Length < 1) { errorProvider1.Clear(); return; }
            if (string.IsNullOrEmpty(strings[0])) { errorProvider1.Clear(); return; }

            foreach (string filePathString in strings) {
                if (!File.Exists(filePathString)) {
                    SystemSounds.Asterisk.Play();
                    errorProvider1.SetError(FileSelectTextBox, "V‰‰r‰ tiedostopolku!" + Environment.NewLine + filePathString);
                    //Select the line where the error occured
                    FileSelectTextBox.SelectionStart = FileSelectTextBox.Text.IndexOf(filePathString);
                    FileSelectTextBox.SelectionLength = filePathString.Length;
                    return;
                }
            }
            errorProvider1.Clear();
        }

        private void InsertFiles(int startIndex, object sender) {
            int filePathStringListIndex = 0;
            foreach (string filePath in filePathStringList) {
                pdfLoadedDocument = new(filePath);
                for (int i = 0; i < pdfLoadedDocument.Pages.Count; i++) {
                    //Set page number and add loaded document item to Listview.
                    if (sender.Equals(InsertButton)) {
                        listView1.Items.Add(GenerateListViewItem((i + 1).ToString(), Path.GetFileName(filePathStringList[filePathStringListIndex]), filePathStringList[filePathStringListIndex], i.ToString()));
                    } else {
                        listView1.Items.Insert(i + startIndex, GenerateListViewItem((i + 1).ToString(), Path.GetFileName(filePath), filePath, i.ToString()));
                    }
                    listView1.Items[i + startIndex].Checked = true;
                }
                startIndex += pdfLoadedDocument.Pages.Count;
                filePathStringListIndex++;
                pdfLoadedDocument.Close();
            }
        }

        private void listView1_ItemChecked(object sender, ItemCheckedEventArgs e) {
            HandleFileOperationsButtonsState();
        }
    }
}