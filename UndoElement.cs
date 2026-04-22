using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rename_files_to_parent_folder
{
    public class UndoElement
    {
        private string old_file_name;
        private string new_file_name;

        public UndoElement(string old_file_name, string new_file_name)
        {
            this.old_file_name = old_file_name;
            this.new_file_name = new_file_name;
        }

        public string getOldFileName() { return old_file_name; }
        public string getNewFileName() { return new_file_name; }
    }
}
