        public static string FileFilter(string filename, OS os)
        {
            int i_file;
            bool is_ok = false;
            string filename_t = null;
            Folder actualFolder = Programs.getCurrentFolder(os);

            if (actualFolder.containsFile(filename))
            {
                if (!actualFolder.containsFile(filename + "(1)"))
                {
                    return filename + "(1)";
                }
                else
                {
                    i_file = 1;
                    is_ok = false;
                    while (actualFolder.containsFile(filename + "(" + i_file + ")") && is_ok == false)
                    {
                        if (!actualFolder.containsFile(filename + "(" + (i_file + 1) + ")"))
                        {
                            i_file++;
                            is_ok = true;
                            filename_t = filename + "(" + i_file + ")";
                        } else
                        {
                            i_file++;
                        }
                            
                    }
                    return filename_t;
                }
            } else
            {
                return filename;
            }
        }
