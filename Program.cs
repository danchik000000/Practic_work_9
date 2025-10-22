using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1Person
     Person person = new Person("Егорчик", 19);
     person.SayHello();
        }
    }
}
namespace Task2Phone
            Phone phone = new Phone("Samsung", 82);
            phone.UsePhone();
            phone.UsePhone();
        }
    }
}
namespace Task3BackAccount
                BankAccount account = new BankAccount("Егор", 500); 
            account.Deposit(500);
            account.Withdraw(500);
            account.Withdraw(1000);
        }
    }
}
namespace Task4Circle
            Circle circle = new Circle(5);
        circle.GetArea();
        try
        {
            // некорректный радиус
            circle.Radius = -2;
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
namespace Task5Pet
            Pet cat = new Pet("Барсик",35);
            cat.Play();    
            cat.Rest();    
        }
    }
}
