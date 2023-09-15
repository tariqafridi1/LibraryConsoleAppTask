using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryConsoleAppTask
{
    internal class User
    {
    public string Name { get; set; }
    public int LibraryCard { get; set; }
    public User(string name, int libraryCard)
    {
        Name = name;
        LibraryCard = libraryCard;

    }
}
}
