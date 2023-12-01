using RandomPasswordsAndHashing;
using System.Security.Cryptography;
using System.Text;


HashPassword hashPassword = new HashPassword();
RandomPasswordCreate passwordCreate = new RandomPasswordCreate();

//Random Password yaradilir

int uzunluq =int.Parse(Console.ReadLine());
string randPassword = passwordCreate.CreatePassword(uzunluq);
Console.WriteLine("Random Password: "+ randPassword);


//Password Hashlanir

string hashedPassword = hashPassword.ComputeSha256Hash(randPassword);
Console.WriteLine("Password Hashed: "+hashedPassword);

Console.ReadKey();
