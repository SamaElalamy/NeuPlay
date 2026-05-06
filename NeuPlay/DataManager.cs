using System;
using System.IO; 
using System.Windows.Forms;

namespace NeuPlay
{
    internal class DataManager
    {
        
        private readonly string filePath = Application.StartupPath + "\\UsersData.txt";

        
        private void EnsureFileExists()
        {
            if (!File.Exists(filePath))
            {
                File.Create(filePath).Close();
            }
        }

        
        private bool IsUserExists(string username)
        {
            if (!File.Exists(filePath)) return false;

            var lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                if (string.IsNullOrWhiteSpace(line)) continue;
                string[] parts = line.Split('|');

                
                if (parts.Length > 0 && parts[0].Equals(username, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }
            return false;
        }

        

        public bool SignUp(Users user)
        {
            try
            {
                EnsureFileExists();
                if (IsUserExists(user.Name))
                {
                    MessageBox.Show("This username is already taken.");
                    return false;
                }

                
                
                string userData = string.Join("|",
                    user.Name,
                    user.Password,
                    user.Type.ToString(),
                    user.KnowsCondition,
                    user.Age.ToString()
                );

                File.AppendAllLines(filePath, new[] { userData });
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Registration Error: " + ex.Message);
                return false;
            }
        }

        public Users LogIn(string name, string password)
        {
            try
            {
                EnsureFileExists();
                var lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    if (string.IsNullOrWhiteSpace(line)) continue;
                    string[] parts = line.Split('|');

                    if (parts.Length >= 5)
                    {
                        if (parts[0].Equals(name, StringComparison.OrdinalIgnoreCase) && parts[1] == password)
                        {
                            return MapPartsToUser(parts);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Login Error: " + ex.Message);
            }
            return null;
        }

        private Users MapPartsToUser(string[] parts)
        {
            Enum.TryParse(parts[2], out UserType type);
            int.TryParse(parts[4], out int age);

            return new Users(parts[0], parts[1], type, parts[3], age);
        }
    }
}