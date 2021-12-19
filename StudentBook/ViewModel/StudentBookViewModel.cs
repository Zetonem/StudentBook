using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using GalaSoft.MvvmLight.Messaging;
using StudentBook.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;

namespace StudentBook.ViewModel
{
    class StudentBookViewModel : ViewModelBase
    {
        public class CCurrentUser
        {
            public String UserType { get; set; }
            public String FullName { get; set; }
            public String FirstLetter { get; set; }
        }

        private const String InitialViewName = "InitialView";
        private const String EmployeeViewName = "EmployeeView";
        private const String StudentViewName = "StudentView";
        private const String TeacherViewName = "TeacherView";
        private const String StudentBookViewName = "StudentBookView";

        private FrameworkElement _contentControlView;
        private List<StudentBook.Model.StudentBook> _allStudentBooks = new List<Model.StudentBook>();
        private StudentBook.Model.StudentBook _studentBook;
        private String _currentUserType = String.Empty;
        private CCurrentUser _currentUser;

        private String _currentFirstName, _currentLastName, _currentPatronymic;

        #region StudentProperty
        private String _currentStudentFirstName, _currentStudentLastName, _currentStudentPatronymic;
        private String _currentFaculty, _currentSpeciality, _currentGroup;

        public String CurrentStudentFirstName
        {
            get => _currentStudentFirstName;
            set
            {
                _currentStudentFirstName = value;
                RaisePropertyChanged("CurrentStudentFirstName");
            }
        }
        public String CurrentStudentLastName
        {
            get => _currentStudentLastName;
            set
            {
                _currentStudentLastName = value;
                RaisePropertyChanged("CurrentStudentLastName");
            }
        }
        public String CurrentStudentPatronymic
        {
            get => _currentStudentPatronymic;
            set
            {
                _currentStudentPatronymic = value;
                RaisePropertyChanged("CurrentStudentPatronymic");
            }
        }
        public String CurrentFaculty
        {
            get => _currentFaculty;
            set
            {
                _currentFaculty = value;
                RaisePropertyChanged("CurrentFaculty");
            }
        }
        public String CurrentSpeciality
        {
            get => _currentSpeciality;
            set
            {
                _currentSpeciality = value;
                RaisePropertyChanged("CurrentSpeciality");
            }
        }
        public String CurrentGroup
        {
            get => _currentGroup;
            set
            {
                _currentGroup = value;
                RaisePropertyChanged("CurrentGroup");
            }
        }
        #endregion

        #region PracticeProperty
        private String _currentType;
        private String _currentRailway;
        private String _currentPlace;
        private DateTime _currentStartDate = DateTime.Today;
        private DateTime _currentEndDate = DateTime.Today;

        public String CurrentType
        {
            get => _currentType;
            set
            {
                _currentType = value;
                RaisePropertyChanged("CurrentType");
            }
        }
        public String CurrentRailway
        {
            get => _currentRailway;
            set
            {
                _currentRailway = value;
                RaisePropertyChanged("CurrentRailway");
            }
        }
        public String CurrentPlace
        {
            get => _currentPlace;
            set
            {
                _currentPlace = value;
                RaisePropertyChanged("CurrenCurrentPlace");
            }
        }
        public DateTime CurrentStartDate
        {
            get => _currentStartDate;
            set
            {
                _currentStartDate = value;
                RaisePropertyChanged("CurrentStartDate");
            }
        }
        public DateTime CurrentEndDate
        {
            get => _currentEndDate;
            set
            {
                _currentEndDate = value;
                RaisePropertyChanged("CurrentEndDate");
            }
        }
        #endregion

        #region ReviewProperty
        private String[] _currentWork = new String[3];
        private String _currentRelation;

        public String CurrentWork1
        {
            get => _currentWork[0];
            set
            {
                _currentWork[0] = value;
                RaisePropertyChanged("CurrentWork1");
            }
        }
        public String CurrentWork2
        {
            get => _currentWork[1];
            set
            {
                _currentWork[1] = value;
                RaisePropertyChanged("CurrentWork2");
            }
        }
        public String CurrentWork3
        {
            get => _currentWork[2];
            set
            {
                _currentWork[2] = value;
                RaisePropertyChanged("CurrentWork3");
            }
        }
        public String CurrentRelation
        {
            get => _currentRelation;
            set
            {
                _currentRelation = value;
                RaisePropertyChanged("CurrentRelation");
            }
        }
        #endregion

        #region ExamProperty
        private DateTime _issueDate;
        private int? _number = 0, _digit = 0;
        private String _specialityName, _rank, _stringDigit;
        private String _productionHeadFirstName, _productionHeadSecondName, _productionHeadPatronymic, _telNumber, _position;
        private String _chairHeadFirstName, _chairHeadSecondName, _chairHeadPatronymic;

        public DateTime CurrentIssueDate
        {
            get => _issueDate;
            set
            {
                _issueDate = value;
                RaisePropertyChanged("CurrentIssueDate");
            }
        }
        public int? CurrentNumber
        {
            get => _number;
            set
            {
                _number = value;
                RaisePropertyChanged("CurrentNumber");
            }
        }
        public String CurrentSpecialityName
        {
            get => _specialityName;
            set
            {
                _specialityName = value;
                RaisePropertyChanged("CurrentSpecialityName");
            }
        }
        public String CurrentRank
        {
            get => _rank;
            set
            {
                _rank = value;
                RaisePropertyChanged("CurrentRank");
            }
        }
        public int? CurrentDigit
        {
            get => _digit;
            set
            {
                _digit = value;
                RaisePropertyChanged("CurrentDigit");
            }
        }
        public String CurrentStringDigit
        {
            get => _stringDigit;
            set
            {
                _stringDigit = value;
                RaisePropertyChanged("CurrentStringDigit");
            }
        }
        public String CurrentProductionHeadFirstName
        {
            get => _productionHeadFirstName;
            set
            {
                _productionHeadFirstName = value;
                RaisePropertyChanged("CurrentProductionHeadFirstName");
            }
        }
        public String CurrentProductionHeadLastName
        {
            get => _productionHeadSecondName;
            set
            {
                _productionHeadSecondName = value;
                RaisePropertyChanged("CurrentProductionHeadSecondName");
            }
        }
        public String CurrentProductionHeadPatronymic
        {
            get => _productionHeadPatronymic;
            set
            {
                _productionHeadPatronymic = value;
                RaisePropertyChanged("CurrentProductionHeadPatronymic");
            }
        }
        public String CurrentTelNumber
        {
            get => _telNumber;
            set
            {
                _telNumber = value;
                RaisePropertyChanged("CurrentTelNumber");
            }
        }
        public String CurrentPosition
        {
            get => _position;
            set
            {
                _position = value;
                RaisePropertyChanged("CurrentPosition");
            }
        }
        public String CurrentChairHeadFirstName
        {
            get => _chairHeadFirstName;
            set
            {
                _chairHeadFirstName = value;
                RaisePropertyChanged("CurrentChairHeadFirstName");
            }
        }
        public String CurrentChairHeadLastName
        {
            get => _chairHeadSecondName;
            set
            {
                _chairHeadSecondName = value;
                RaisePropertyChanged("CurrentChairHeadSecondName");
            }
        }
        public String CurrentChairHeadPatronymic
        {
            get => _chairHeadPatronymic;
            set
            {
                _chairHeadPatronymic = value;
                RaisePropertyChanged("CurrentChairHeadPatronymic");
            }
        }
        #endregion

        private ObservableCollection<String> _studentPracticesCollection, _allStudentsCollection;

        public String CurrentFirstName
        {
            get => _currentFirstName;
            set
            {
                _currentFirstName = value;
                RaisePropertyChanged("CurrentFirstName");
            }
        }
        public String CurrentLastName
        {
            get => _currentLastName;
            set
            {
                _currentLastName = value;
                RaisePropertyChanged("CurrentLastName");
            }
        }
        public String CurrentPatronymic
        {
            get => _currentPatronymic;
            set
            {
                _currentPatronymic = value;
                RaisePropertyChanged("CurrentPatronymic");
            }
        }

        public ObservableCollection<String> StudentPracticesCollection
        {
            get => _studentPracticesCollection;
            set => _studentPracticesCollection = value;
        }

        public ObservableCollection<String> AllStudentsCollection
        {
            get => _allStudentsCollection;
            set => _allStudentsCollection = value;
        }

        public CCurrentUser CurrentUser
        {
            get => _currentUser;
            set
            {
                _currentUser = value;
                RaisePropertyChanged("CurrentUser");
            }
        }

        public FrameworkElement ContentControlView
        {
            get { return _contentControlView; }
            set
            {
                _contentControlView = value;
                RaisePropertyChanged("ContentControlView");
            }
        }

        public ICommand ChangeViewCommand
        {
            get
            {
                return new RelayCommand<object>((role) =>
                {
                    String roleStr = role as String;
                    switch (roleStr)
                    {
                        case "Employee":
                            _currentUserType = EmployeeViewName;
                            CurrentUser = new CCurrentUser
                            {
                                FullName = CurrentLastName + ' ' + CurrentFirstName + ' ' + CurrentPatronymic,
                                FirstLetter = CurrentLastName[0].ToString(),
                                UserType = roleStr
                            };
                            SwitchView(EmployeeViewName);
                            break;
                        case "Student":
                            _currentUserType = StudentViewName;
                            CurrentUser = new CCurrentUser
                            {
                                FullName = CurrentLastName + ' ' + CurrentFirstName + ' ' + CurrentPatronymic,
                                FirstLetter = CurrentLastName[0].ToString(),
                                UserType = roleStr
                            };
                            SwitchView(StudentViewName);
                            break;
                        case "Teacher":
                            _currentUserType = TeacherViewName;
                            CurrentUser = new CCurrentUser
                            {
                                FullName = CurrentLastName + ' ' + CurrentFirstName + ' ' + CurrentPatronymic,
                                FirstLetter = CurrentLastName[0].ToString(),
                                UserType = roleStr
                            };
                            SwitchView(TeacherViewName);
                            break;
                        case "StudentBook":
                            SwitchView(StudentBookViewName);
                            break;
                        default:
                            _currentUserType = String.Empty;
                            SwitchView(InitialViewName);
                            break;
                    }
                });
            }
        }

        public ICommand GetStudentBookCommand
        {
            get
            {
                return new RelayCommand<object>((object o) =>
                {
                    String fullName = o as String;
                    var nameParts = fullName.Split(' ');
                    String lastName = nameParts[0];
                    String firstName = nameParts[1];
                    String patronymic = nameParts[2];
                    int i = 0;
                    foreach (var s in _allStudentBooks)
                    {
                        if (lastName == s.StudentProperty.FullName.LastName &&
                            firstName == s.StudentProperty.FullName.FirstName &&
                            patronymic == s.StudentProperty.FullName.Patronymic)
                        {
                            _studentBook = s;
                            break;
                        }
                        i++;
                    }
                    _allStudentBooks.RemoveAt(i);
                    SetCurrent();
                    SwitchView(StudentBookViewName);
                });
            }
        }

        public ICommand CloseStudentBookCommand
        {
            get
            {
                return new RelayCommand(() =>
                {
                    SubmitChanges(_currentUserType);
                });
            }
        }

        public StudentBook.Model.StudentBook StudentBook
        {
            get
            {
                return _studentBook;
            }
            set
            {
                _studentBook = value;
                RaisePropertyChanged("StudentBook");
            }
        }

        public StudentBookViewModel()
        {
            _studentPracticesCollection = new ObservableCollection<String>();
            _allStudentsCollection = new ObservableCollection<String>();
            _studentBook = new Model.StudentBook();
            ClearCurrent();
            Messenger.Default.Register<SwitchViewMessage>(this, (switchViewMessage) =>
            {
                SwitchView(switchViewMessage.ViewName);
            });
            SwitchView(InitialViewName);
        }

        public void SwitchView(string viewName)
        {
            StudentPracticesCollection?.Clear();
            AllStudentsCollection?.Clear();
            switch (viewName)
            {
                case EmployeeViewName:
                    ContentControlView = new EmployeeView();
                    foreach (var s in _allStudentBooks)
                    {
                        AllStudentsCollection.Add(s.StudentProperty.FullName.LastName + ' ' + s.StudentProperty.FullName.FirstName +
                            ' ' + s.StudentProperty.FullName.Patronymic + ' ' + s.PracticeProperty.StartDate);
                    }
                    break;
                case StudentViewName:
                    foreach (var s in _allStudentBooks)
                    {
                        if (CurrentLastName == s.StudentProperty.FullName.LastName &&
                            CurrentFirstName == s.StudentProperty.FullName.FirstName &&
                            CurrentPatronymic == s.StudentProperty.FullName.Patronymic)
                        {
                            StudentPracticesCollection.Add(CurrentUser.FullName + ' ' + s.PracticeProperty.StartDate);
                        }
                    }
                    ContentControlView = new StudentView();
                    break;
                case TeacherViewName:
                    foreach (var s in _allStudentBooks)
                    {
                        AllStudentsCollection.Add(s.StudentProperty.FullName.LastName + ' ' + s.StudentProperty.FullName.FirstName +
                            ' ' + s.StudentProperty.FullName.Patronymic + ' ' + s.PracticeProperty.StartDate);
                    }
                    ContentControlView = new TeacherView();
                    break;
                case StudentBookViewName:
                    switch (_currentUserType)
                    {
                        case EmployeeViewName:
                            if (CurrentProductionHeadFirstName == null || CurrentProductionHeadFirstName == String.Empty)
                                CurrentProductionHeadFirstName = CurrentFirstName;
                            if (CurrentProductionHeadLastName == null || CurrentProductionHeadLastName == String.Empty)
                                CurrentProductionHeadLastName = CurrentLastName;
                            if (CurrentProductionHeadPatronymic == null || CurrentProductionHeadPatronymic == String.Empty)
                                CurrentProductionHeadPatronymic = CurrentPatronymic;
                            CurrentFirstName = String.Empty;
                            CurrentLastName = String.Empty;
                            CurrentPatronymic = String.Empty;
                            break;
                        case StudentViewName:
                            if (CurrentStudentFirstName == null || CurrentStudentFirstName == String.Empty)
                                CurrentStudentFirstName = CurrentFirstName;
                            if (CurrentStudentLastName == null || CurrentStudentLastName == String.Empty)
                                CurrentStudentLastName = CurrentLastName;
                            if (CurrentStudentPatronymic == null || CurrentStudentPatronymic == String.Empty)
                                CurrentStudentPatronymic = CurrentPatronymic;
                            break;
                        case TeacherViewName:
                            if (CurrentChairHeadFirstName == null || CurrentChairHeadFirstName == String.Empty)
                                CurrentChairHeadFirstName = CurrentFirstName;
                            if (CurrentChairHeadLastName == null || CurrentChairHeadLastName == String.Empty)
                                CurrentChairHeadLastName = CurrentLastName;
                            if (CurrentChairHeadPatronymic == null || CurrentChairHeadPatronymic == String.Empty)
                                CurrentChairHeadPatronymic = CurrentPatronymic;
                            CurrentFirstName = String.Empty;
                            CurrentLastName = String.Empty;
                            CurrentPatronymic = String.Empty;
                            break;
                    }
                    ContentControlView = new StudentBookView(_currentUserType);
                    break;
                default:
                    CurrentFirstName = String.Empty;
                    CurrentLastName = String.Empty;
                    CurrentPatronymic = String.Empty;
                    ContentControlView = new InitialView();
                    break;
            }
            ContentControlView.DataContext = this;
        }

        private void SubmitChanges(String viewName)
        {
            _studentBook.StudentProperty = new Model.StudentBook.Student
            {
                FullName = new Model.StudentBook.FullName
                {
                    FirstName = CurrentStudentFirstName,
                    LastName = CurrentStudentLastName,
                    Patronymic = CurrentPatronymic
                },
                Faculty = CurrentFaculty,
                Speciality = CurrentSpeciality,
                Group = CurrentGroup
            };
            _studentBook.PracticeProperty = new Model.StudentBook.Practice
            {
                Type = CurrentType,
                Railway = CurrentRailway,
                Place = CurrentPlace,
                StartDate = CurrentStartDate,
                EndDate = CurrentEndDate
            };
            _studentBook.ReviewProperty = new Model.StudentBook.Review
            {
                Relation = CurrentRelation,
                Work = new List<String> { CurrentWork1, CurrentWork2, CurrentWork3 }
            };
            _studentBook.ExamProperty = new Model.StudentBook.Exam
            {
                IssueDate = CurrentIssueDate,
                Number = CurrentNumber == null ? 0 : CurrentNumber.Value,
                SpecialityName = CurrentSpecialityName,
                Rank = CurrentRank,
                ProductionHead = new Model.StudentBook.ProductionHead
                {
                    FullName = new Model.StudentBook.FullName
                    {
                        FirstName = CurrentProductionHeadFirstName,
                        LastName = CurrentProductionHeadLastName,
                        Patronymic = CurrentProductionHeadPatronymic
                    }
                },
                ChairHead = new Model.StudentBook.ChairHead
                {
                    FullName = new Model.StudentBook.FullName
                    {
                        FirstName = CurrentChairHeadFirstName,
                        LastName = CurrentChairHeadLastName,
                        Patronymic = CurrentChairHeadPatronymic
                    },
                    Position = CurrentPosition,
                    TelNumber = CurrentTelNumber
                },
                Mark = new Model.StudentBook.ChairMark
                {
                    Digit = CurrentDigit == null ? 0 : CurrentDigit.Value,
                    StringDigit = CurrentStringDigit
                }
            };
            _allStudentBooks.Add(_studentBook);
            SwitchView(viewName);
            ClearCurrent();
        }

        private void SetCurrent()
        {
            CurrentStudentFirstName = _studentBook.StudentProperty.FullName.FirstName;
            CurrentStudentLastName = _studentBook.StudentProperty.FullName.LastName;
            CurrentStudentPatronymic = _studentBook.StudentProperty.FullName.Patronymic;
            CurrentFaculty = _studentBook.StudentProperty.Faculty;
            CurrentSpeciality = _studentBook.StudentProperty.Speciality;
            CurrentGroup = _studentBook.StudentProperty.Group;
            CurrentRailway = _studentBook.PracticeProperty.Railway;
            CurrentPlace = _studentBook.PracticeProperty.Place;
            CurrentStartDate = _studentBook.PracticeProperty.StartDate == null ? DateTime.Today : _studentBook.PracticeProperty.StartDate;
            CurrentEndDate = _studentBook.PracticeProperty.EndDate == null ? DateTime.Today : _studentBook.PracticeProperty.EndDate;
            if (_studentBook.ReviewProperty.Work != null)
            {
                if (_studentBook.ReviewProperty.Work.Count > 0)
                    CurrentWork1 = _studentBook.ReviewProperty.Work[0];
                if (_studentBook.ReviewProperty.Work.Count > 1)
                    CurrentWork2 = _studentBook.ReviewProperty.Work[1];
                if (_studentBook.ReviewProperty.Work.Count > 2)
                    CurrentWork3 = _studentBook.ReviewProperty.Work[2];
            }
            CurrentRelation = _studentBook.ReviewProperty.Relation;
            CurrentIssueDate = _studentBook.ExamProperty.IssueDate == null ? DateTime.Today : _studentBook.ExamProperty.IssueDate;
            CurrentNumber = _studentBook.ExamProperty.Number;
            CurrentSpecialityName = _studentBook.ExamProperty.SpecialityName;
            CurrentRank = _studentBook.ExamProperty.Rank;
            CurrentDigit = _studentBook.ExamProperty.Mark.Digit;
            CurrentStringDigit = _studentBook.ExamProperty.Mark.StringDigit;
            CurrentProductionHeadFirstName = _studentBook.ExamProperty.ProductionHead.FullName.FirstName;
            CurrentProductionHeadLastName = _studentBook.ExamProperty.ProductionHead.FullName.LastName;
            CurrentProductionHeadPatronymic = _studentBook.ExamProperty.ProductionHead.FullName.Patronymic;
            CurrentTelNumber = _studentBook.ExamProperty.ChairHead.TelNumber;
            CurrentPosition = _studentBook.ExamProperty.ChairHead.Position;
            CurrentChairHeadFirstName = _studentBook.ExamProperty.ChairHead.FullName.FirstName;
            CurrentChairHeadLastName = _studentBook.ExamProperty.ChairHead.FullName.LastName;
            CurrentChairHeadPatronymic = _studentBook.ExamProperty.ChairHead.FullName.Patronymic;
        }

        private void ClearCurrent()
        {
            CurrentStudentFirstName = String.Empty;
            CurrentStudentLastName = String.Empty;
            CurrentStudentPatronymic = String.Empty;
            CurrentFaculty = String.Empty;
            CurrentSpeciality = String.Empty;
            CurrentGroup = String.Empty;
            CurrentRailway = String.Empty;
            CurrentPlace = String.Empty;
            CurrentStartDate = DateTime.Today;
            CurrentEndDate = DateTime.Today;
            CurrentWork1 = String.Empty;
            CurrentWork2 = String.Empty;
            CurrentWork3 = String.Empty;
            CurrentRelation = String.Empty;
            CurrentIssueDate = DateTime.Today;
            CurrentNumber = null;
            CurrentSpecialityName = String.Empty;
            CurrentRank = String.Empty;
            CurrentDigit = null;
            CurrentStringDigit = String.Empty;
            CurrentProductionHeadFirstName = String.Empty;
            CurrentProductionHeadLastName = String.Empty;
            CurrentProductionHeadPatronymic = String.Empty;
            CurrentTelNumber = String.Empty;
            CurrentPosition = String.Empty;
            CurrentChairHeadFirstName = String.Empty;
            CurrentChairHeadLastName = String.Empty;
            CurrentChairHeadPatronymic = String.Empty;
        }
    }
}
