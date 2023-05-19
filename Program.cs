internal class Program
    {
    static Student[] studentList = new Student[85858080];
    static int Count = 0;
    private static void Main ( string[] args )
        {
        Console.WriteLine("\n---IPBSES.com\nStudents Database List (Struct Practice)\n\n");

        int key;

        while (true)
            {
            Console.Write("\n\n\t\t1. Add Student 2. Show List 3. Search List 4. Edit Entry 5. Delete 6. Restore 7. Exit: ");
            key = int.Parse(Console.ReadLine());

            switch (key)
                {
                case 1:
                    SetStudent();
                    break;
                case 2:
                    ShowList();
                    break;
                case 3:
                    SearchList();
                    break;
                case 4:
                    EditStudent();
                    break;
                case 5:
                    DeleteStudent();
                    break;
                case 6:
                    RestoreStudent();
                    break;
                case 7:
                    return;
                }
            }
        }

    struct Student
        {
        public int ID;
        public string Name;
        public string LastName;
        public Boolean delete;
        }

    public static void SetStudent ()
        {
        Console.Write("\nID: ");
        studentList[Count].ID = int.Parse(Console.ReadLine());
        Console.Write("\nName: ");
        studentList[Count].Name = Console.ReadLine();
        Console.Write("\nLast Name: ");
        studentList[Count].LastName = Console.ReadLine();
        studentList[Count].delete = false;
        Count++;
        }

    public static void ShowList ()
        {
        for (int i = 0; i < Count; i++)
            {
            if (studentList[i].delete != true)
                {
                Console.WriteLine("ID: '" + studentList[i].ID + "', Student Name: '" + studentList[i].Name + "', Student's Last Name: '" + studentList[i].LastName + "'");
                }
            }
        }

    public static void SearchList ()
        {
        Console.Write("Enter ID of the student for Search: ");
        int keyForSearch = int.Parse(Console.ReadLine());
        int f = -1;
        for (int i = 0; i < Count; i++)
            {
            if (studentList[i].ID == keyForSearch)
                {
                f = i;
                }
            }
        if (f == -1)
            {
            Console.WriteLine("Not found");
            }
        else
            {
            Console.WriteLine("Found " + studentList[f].ID + " --> Name: '" + studentList[f].Name + "', LastName: '" + studentList[f].LastName + "'");
            }

        }

    public static void EditStudent ()
        {
        Console.Write("Enter ID of the student for Edit: ");
        int keyForEdit = int.Parse(Console.ReadLine());
        int f = -1;
        for (int i = 0; i < Count; i++)
            {
            if (studentList[i].ID == keyForEdit)
                {
                f = i;
                Console.Write("Please type in the new Name: ");
                studentList[i].Name = Console.ReadLine();
                Console.Write("Please type in the new Lastname: ");
                studentList[i].LastName = Console.ReadLine();
                }
            }
        if (f == -1)
            {
            Console.WriteLine("Not found");
            }
        else
            {
            Console.WriteLine("Found " + studentList[f].ID + " --> Name: '" + studentList[f].Name + "', LastName: '" + studentList[f].LastName + "'");
            }
        }

    public static void DeleteStudent ()
        {
        Console.Write("Enter ID of the student to Delete: ");
        int keyForDelete = int.Parse(Console.ReadLine());
        int f = -1;
        for (int i = 0; i < Count; i++)
            {
            if (studentList[i].ID == keyForDelete)
                {
                f = i;
                studentList[i].delete = true;
                }
            }
        if (f == -1)
            {
            Console.WriteLine("Not found");
            }
        else
            {
            Console.WriteLine("Found " + studentList[f].ID + " --> Name: '" + studentList[f].Name + "', LastName: '" + studentList[f].LastName + "' & Deleted Successfully!");
            }
        }

    public static void RestoreStudent ()
        {
        Console.Write("Enter ID of the student to Restore: ");
        int keyForDelete = int.Parse(Console.ReadLine());
        int f = -1;
        for (int i = 0; i < Count; i++)
            {
            if (studentList[i].ID == keyForDelete)
                {
                f = i;
                studentList[i].delete = false;
                }
            }
        if (f == -1)
            {
            Console.WriteLine("Not found");
            }
        else
            {
            Console.WriteLine("Found " + studentList[f].ID + " --> Name: '" + studentList[f].Name + "', LastName: '" + studentList[f].LastName + "' & Restored Successfully!");
            }
        }
    }
