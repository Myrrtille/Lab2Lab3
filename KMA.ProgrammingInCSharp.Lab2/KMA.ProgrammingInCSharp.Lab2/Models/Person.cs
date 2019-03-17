using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMA.ProgrammingInCSharp.Lab2
{
    class Person
    {
        #region Fields

        private string _firstName;
        private string _lastName;
        private string _email;
        private DateTime _birthDate;

        private readonly string[] _westSignsArr =
        {
            "Aquarius", "Pisces", "Aries", "Taurus", "Gemini", "Cancer", "Leo", "Virgo", "Libra", "Scorpio",
            "Sagittatius", "Capricorn"
        };

        private readonly string[] _chineseSignArr =
        {
            "Monkey", "Rooster", "Dog", "Pig", "Rat", "Ox", "Tiger", "Rabbit", "Dragon", "Snake", "Horse", "Sheep"
        };

        #endregion

        #region Constructors
        public Person(string firstName, string lastName, string email, DateTime birthDate)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            BirthDate = birthDate;
        }

        public Person(string firstName, string lastName, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
        }

        public Person(string firstName, string lastName, DateTime birthDate)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
        }
        #endregion

        #region Properties
        internal string FirstName
        {
            get { return _firstName; }
            private set { _firstName = value; }
        }
        internal string LastName
        {
            get { return _lastName; }
            private set { _lastName = value; }
        }
        internal string Email
        {
            get { return _email; }
            private set { _email = value; }
        }
        internal DateTime BirthDate
        {
            get { return _birthDate; }
            private set { _birthDate = value; }
        }

        internal bool IsAdult
        {
            get { return ((DateTime.Today.Subtract(_birthDate)).TotalDays / 365) > 18; }
            private set { }
        }

        internal string SunSign
        {
            get
            {
                switch (_birthDate.Month)
                {
                    case 1:
                        return _birthDate.Day <= 20 ? _westSignsArr[11] : _westSignsArr[0];
                    case 2:
                        return _birthDate.Day <= 18 ? _westSignsArr[0] : _westSignsArr[1];
                    case 3:
                        return _birthDate.Day <= 20 ? _westSignsArr[1] : _westSignsArr[2];
                    case 4:
                        return _birthDate.Day <= 20 ? _westSignsArr[2] : _westSignsArr[3];
                    case 5:
                        return _birthDate.Day <= 20 ? _westSignsArr[3] : _westSignsArr[4];
                    case 6:
                        return _birthDate.Day <= 21 ? _westSignsArr[4] : _westSignsArr[5];
                    case 7:
                        return _birthDate.Day <= 22 ? _westSignsArr[5] : _westSignsArr[6];
                    case 8:
                        return _birthDate.Day <= 22 ? _westSignsArr[6] : _westSignsArr[7];
                    case 9:
                        return _birthDate.Day <= 22 ? _westSignsArr[7] : _westSignsArr[8];
                    case 10:
                        return _birthDate.Day <= 23 ? _westSignsArr[8] : _westSignsArr[9];
                    case 11:
                        return _birthDate.Day <= 22 ? _westSignsArr[9] : _westSignsArr[10];
                    case 12:
                        return _birthDate.Day <= 21 ? _westSignsArr[10] : _westSignsArr[11];
                    default:
                        return "";
                }
            }
            private set { }
        }

        internal string ChineseSign
        {
            get
            {
                try
                {
                    return _chineseSignArr[_birthDate.Year % 12];
                }
                catch (Exception)
                {
                    return "";
                }
            }
            private set { }
        }

        internal bool IsBirthday
        {
            get { return (_birthDate.Month == DateTime.Today.Month && _birthDate.Day == DateTime.Today.Day); }
            private set { }
        }
        #endregion

    }
}
