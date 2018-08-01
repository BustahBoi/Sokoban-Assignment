using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokoban_FileHandler
{
    public interface IForm
    {
        event LoaderEvent LoadEvent;
        event SaverEvent SaveEvent;
        string Return_FileName();
        FilerForm Init_Form();
        void Update_ErrorLabel(string ErrorResult);
        void Show_Form();
        void Disable_Save();
        void Enable_Save();
        void Enable_Load();
        void Disable_Load();
    }
}
