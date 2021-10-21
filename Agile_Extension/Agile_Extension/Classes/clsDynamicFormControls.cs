using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroSet_UI;
using MetroSet_UI.Forms;
using System.Drawing;
using System.Windows.Forms;
using CircularProgressBar;

//HRR POTGIETER
//Reason for Class:
//This class handles all dynamic components of the dashboard form
namespace Agile_Extension.Classes
{
    class clsDynamicFormControls
    {
        #region INSTANCE_VARIABLES
        //Intance
        private string control_text;
        private int local_one;
        private int local_two;
        private int size_one;
        private int size_two;
        #endregion

        #region CONSTRUCTORS
        //Controls that require text
        public clsDynamicFormControls(string control_text, int local_one, int local_two, int size_one, int size_two)
        {
            setControlText(control_text);
            setLocalOne(local_one);
            setLocalTwo(local_two);
            setSizeOne(size_one);
            setSizeTwo(size_two);
        }
       
        //Controls that do not require text
        public clsDynamicFormControls(int local_one, int local_two, int size_one, int size_two)
        {
            setLocalOne(local_one);
            setLocalTwo(local_two);
            setSizeOne(size_one);
            setSizeTwo(size_two);
        }
        #endregion

        #region SET_METHODS
        //SET METHODS
        private void setControlText(string control_name)
        {
            this.control_text = control_name;
        }

        private void setLocalOne(int local_one)
        {
            this.local_one = local_one;
        }

        private void setLocalTwo(int local_two)
        {
            this.local_two = local_two;
        }

        private void setSizeOne(int size_one)
        {
            this.size_one = size_one;
        }
        private void setSizeTwo(int size_two)
        {
            this.size_two = size_two;
        }
        #endregion

        #region GET_METHODS
        //GET METHODS
        private string getControlText()
        {
            return control_text;
        }

        private int getLocalOne()
        {
            return local_one;
        }

        private int getLocalTwo()
        {
            return local_two;
        }

        private int getSizeOne()
        {
            return size_one;
        }

        private int getSizeTwo()
        {
            return size_two;
        }
        #endregion

        #region DYNAMIC_CONTROLS
        public MetroSet_UI.Controls.MetroSetTile createDynamicTile(Control parentControl)
        {
            MetroSet_UI.Controls.MetroSetTile tile = new MetroSet_UI.Controls.MetroSetTile();
            parentControl.Controls.Add(tile);
            tile.Text = getControlText();
            tile.Location = new Point(getLocalOne(), getLocalTwo());
            tile.Size = new Size(getSizeOne(), getSizeTwo());

            return tile;
        }

        public MetroSet_UI.Controls.MetroSetPanel createDynamicPanel(Control parentControl)
        {
            MetroSet_UI.Controls.MetroSetPanel panel = new MetroSet_UI.Controls.MetroSetPanel();
            parentControl.Controls.Add(panel);
            panel.Location = new Point(getLocalOne(), getLocalTwo());
            panel.Size = new Size(getSizeOne(), getSizeTwo());

            return panel;
        }

        public MetroSet_UI.Controls.MetroSetLabel createDynamicLabel (Control parentControl)
        {
            MetroSet_UI.Controls.MetroSetLabel label = new MetroSet_UI.Controls.MetroSetLabel();
            parentControl.Controls.Add(label);
            label.BorderStyle = BorderStyle.FixedSingle;
            label.Text = getControlText();
            label.Location = new Point(getLocalOne(), getLocalTwo());
            label.Size = new Size(getSizeOne(), getSizeTwo());

            return label; 
        }

        public MetroSet_UI.Controls.MetroSetListBox createDynamicListBox (Control parentControl)
        {
            MetroSet_UI.Controls.MetroSetListBox listBox = new MetroSet_UI.Controls.MetroSetListBox();
            parentControl.Controls.Add(listBox);
            listBox.Location = new Point(getLocalOne(), getLocalTwo());
            listBox.Size = new Size(getSizeOne(), getSizeTwo());

            return listBox; 
        }

        public CircularProgressBar.CircularProgressBar createDynamicProgressBar(Control parentControl)
        {
            CircularProgressBar.CircularProgressBar progressBar = new CircularProgressBar.CircularProgressBar();
            parentControl.Controls.Add(progressBar);
            progressBar.Location = new Point(getLocalOne(), getLocalTwo());
            progressBar.Text = getControlText();
            progressBar.Size = new Size(getSizeOne(), getSizeTwo());

            return progressBar;
        }
        #endregion
        
    }
}
