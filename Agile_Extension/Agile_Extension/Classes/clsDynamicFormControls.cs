using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroSet_UI;
using MetroSet_UI.Forms;
using System.Drawing;
using System.Windows.Forms;

//HRR POTGIETER
//Reason for Class:
//This class handles all dynamic components of the dashboard form
namespace Agile_Extension.Classes
{
    class clsDynamicFormControls
    {
        //Intance
        private string control_text;
        private int local_one;
        private int local_two;
        private int size_one;
        private int size_two;

        public clsDynamicFormControls(string control_text, int local_one, int local_two, int size_one, int size_two)
        {
            setName(control_text);
            setLocalOne(local_one);
            setLocalTwo(local_two);
            setSizeOne(size_one);
            setSizeTwo(size_two);
        }

        //SET METHODS
        
        private void setName(string control_name)
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

        public MetroSet_UI.Controls.MetroSetTile createDynamicTile(Control parentControl)
        {
            MetroSet_UI.Controls.MetroSetTile tile = new MetroSet_UI.Controls.MetroSetTile();
            parentControl.Controls.Add(tile);
            tile.Text = getControlText();
            tile.Location = new Point(getLocalOne(), getLocalTwo());
            tile.Size = new Size(getSizeOne(), getSizeTwo());

            return tile;
        }
            
    }

    

}
