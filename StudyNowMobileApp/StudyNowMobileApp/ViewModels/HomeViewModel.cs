using StudyNowMobileApp.Models.Home;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

using Xamarin.Forms;

namespace StudyNowMobileApp.ViewModels
{
    public class HomeViewModel
    {
        /// <summary>
        /// Список курсов.
        /// </summary>
        public IList<Curs> Curs { get; private set; }

        public HomeViewModel()
        {
            Curs = new List<Curs>
            {
                new Curs(){ Name = "Избранное", Description = "Описание", SubCurs = new List<SubCurs>
                                                                                    {
                                                                                        new SubCurs()
                                                                                        {
                                                                                            Name = "С#",
                                                                                            SourceIcon = "TopBar_Profile.png"
                                                                                        },

                                                                                        new SubCurs()
                                                                                        {
                                                                                            Name = "С++",
                                                                                            SourceIcon = "TopBar_Profile.png"
                                                                                        },

                                                                                        new SubCurs()
                                                                                        {
                                                                                            Name = "С",
                                                                                            SourceIcon = "TopBar_Profile.png"
                                                                                        }
                                                                                    }
                },
                new Curs(){ Name = "Не избранное", Description = "Описание", SubCurs = new List<SubCurs>
                                                                    {
                                                                        new SubCurs()
                                                                        {
                                                                            Name = "С#",
                                                                            SourceIcon = "TopBar_Profile.png"
                                                                        },

                                                                        new SubCurs()
                                                                        {
                                                                            Name = "С++",
                                                                            SourceIcon = "TopBar_Profile.png"
                                                                        },

                                                                        new SubCurs()
                                                                        {
                                                                            Name = "С",
                                                                            SourceIcon = "TopBar_Profile.png"
                                                                        }
                                                                    }
                },
                new Curs(){ Name = "Короче гворя", Description = "Описание", SubCurs = new List<SubCurs>
                                                    {
                                                        new SubCurs()
                                                        {
                                                            Name = "С#",
                                                            SourceIcon = "TopBar_Profile.png"
                                                        },

                                                        new SubCurs()
                                                        {
                                                            Name = "С++",
                                                            SourceIcon = "TopBar_Profile.png"
                                                        },

                                                        new SubCurs()
                                                        {
                                                            Name = "С",
                                                            SourceIcon = "TopBar_Profile.png"
                                                        }
                                                    }
                },
                                new Curs(){ Name = "Короче гворя", Description = "Описание", SubCurs = new List<SubCurs>
                                                    {
                                                        new SubCurs()
                                                        {
                                                            Name = "С#",
                                                            SourceIcon = "TopBar_Profile.png"
                                                        },

                                                        new SubCurs()
                                                        {
                                                            Name = "С++",
                                                            SourceIcon = "TopBar_Profile.png"
                                                        },

                                                        new SubCurs()
                                                        {
                                                            Name = "С",
                                                            SourceIcon = "TopBar_Profile.png"
                                                        }
                                                    }
                },
                                                new Curs(){ Name = "Короче гворя", Description = "Описание", SubCurs = new List<SubCurs>
                                                    {
                                                        new SubCurs()
                                                        {
                                                            Name = "С#",
                                                            SourceIcon = "TopBar_Profile.png"
                                                        },

                                                        new SubCurs()
                                                        {
                                                            Name = "С++",
                                                            SourceIcon = "TopBar_Profile.png"
                                                        },

                                                        new SubCurs()
                                                        {
                                                            Name = "С",
                                                            SourceIcon = "TopBar_Profile.png"
                                                        }
                                                    }
                },
                                                                new Curs(){ Name = "Короче гворя", Description = "Описание", SubCurs = new List<SubCurs>
                                                    {
                                                        new SubCurs()
                                                        {
                                                            Name = "С#",
                                                            SourceIcon = "TopBar_Profile.png"
                                                        },

                                                        new SubCurs()
                                                        {
                                                            Name = "С++",
                                                            SourceIcon = "TopBar_Profile.png"
                                                        },

                                                        new SubCurs()
                                                        {
                                                            Name = "С",
                                                            SourceIcon = "TopBar_Profile.png"
                                                        }
                                                    }
                },
                                                                                new Curs(){ Name = "Короче гворя", Description = "Описание", SubCurs = new List<SubCurs>
                                                    {
                                                        new SubCurs()
                                                        {
                                                            Name = "С#",
                                                            SourceIcon = "TopBar_Profile.png"
                                                        },

                                                        new SubCurs()
                                                        {
                                                            Name = "С++",
                                                            SourceIcon = "TopBar_Profile.png"
                                                        },

                                                        new SubCurs()
                                                        {
                                                            Name = "С",
                                                            SourceIcon = "TopBar_Profile.png"
                                                        }
                                                    }
                }
            };
        }
    }
}