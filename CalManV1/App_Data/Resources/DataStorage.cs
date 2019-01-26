using System.Collections.Generic;

namespace Resources
{
    public class Storage : Produce, IProduce
    {
        public List<Produce> produces = new List<Produce>();
        public Storage()
        {
            produces.Add(new Produce
            {
                Name = "Cartofi",
                Cal100 = 76.7,
                Cal50 = 38.35,
                Cal10 = 7.6
            });
            produces.Add(new Produce
            {
                Name = "Banane",
                Cal100 = 89,
                Cal50 = 44.5,
                Cal10 = 8.9
            });
            produces.Add(new Produce
            {
                Name = "Varza",
                Cal100 = 31,
                Cal50 = 15.5,
                Cal10 = 3.1
            });
            produces.Add(new Produce
            {
                Name = "Porumb",
                Cal100 = 58,
                Cal50 = 29,
                Cal10 = 5.8
            });
                produces.Add(new Produce
            {
                Name = "Mere",
                Cal100 = 52.10,
                Cal50 = 26.05,
                Cal10 = 5.2
            });
              produces.Add(new Produce
            {
                Name = "Pere",
                Cal100 =57.10,
                Cal50 =28.55,
                Cal10 = 5.7
            });
              produces.Add(new Produce
            {
                Name = "Ananas",
                Cal100 = 50,
                Cal50 = 25,
                Cal10 =5
            });
            produces.Add(new Produce
            {
                Name = "Branza de burduf",
                Cal100 = 	337	,
                Cal50 = 168.50	,
                Cal10 = 33.7
            }); 
            produces.Add(new Produce
            {
                Name = "Branza grasa de vaci",
                Cal100 = 156	,
                Cal50 = 78.00	,
                Cal10 = 15.6
            });  
            produces.Add(new Produce
            {
                Name = "Carne de caprioara",
                Cal100 = 100,
                Cal50 = 50,
                Cal10 =10
            }); 
            produces.Add(new Produce
            {
                Name = "Carne de iepure",
                Cal100 =98,
                Cal50 = 49.00,
                Cal10 = 9.8
            }); 
            produces.Add(new Produce
            {
                Name = "Carne de miel",
                Cal100 =260,
                Cal50 =130.00,
                Cal10 = 26
            }); 
            produces.Add(new Produce
            {
                Name = "Carne de mistret",
                Cal100 =114,
                Cal50 = 57,
                Cal10 = 11.4
            }); 
            produces.Add(new Produce
            {
                Name = "Carne de rata",
                Cal100 =136,
                Cal50 = 68,
                Cal10 = 13.6 
            });
            produces.Add(new Produce
            {
                Name = "Sunca presata",
                Cal100 =234,
                Cal50 = 117,
                Cal10 = 23.4
            }); 
            produces.Add(new Produce
            {
                Name = "Crap",
                Cal100 =  104,
                Cal50 = 52,
                Cal10 = 10.4
            }); 
            produces.Add(new Produce
            {
                Name = "Salau",
                Cal100 = 83,
                Cal50 =41.50,
                Cal10 = 8.3 
            });
            produces.Add(new Produce
            {
                Name = "Stiuca",
                Cal100 = 82,
                Cal50 = 41.00,
                Cal10 = 8.2
            }); 
            produces.Add(new Produce
            {
                Name = "Oua de gaina",
                Cal100 =85,
                Cal50 = 42.50,
                Cal10 =	8.5 
            });
            produces.Add(new Produce
            {
                Name = "Ardei gras rosu",
                Cal100 =39,
                Cal50 = 19.50,
                Cal10 = 3.9 
           });
           produces.Add(new Produce
            {
                Name = "Ardei gras verde",
                Cal100 =25,
                Cal50 =	12.50,
                Cal10 =	2.5  
             });
            produces.Add(new Produce
            {
                Name = "Ciuperci",
                Cal100 = 35,
                Cal50 = 17.50,
                Cal10 = 3.5
            });
           produces.Add(new Produce
            {
                Name = "Conopida",
                Cal100 =30,
                Cal50 =	15,
                Cal10 =3   
             }); 
            produces.Add(new Produce
            {
                Name = "Dovlecei",
                Cal100 =18,
                Cal50 =	9,
                Cal10 =	1.8 
             });
            produces.Add(new Produce
            {
                Name = "Fasole verde",
                Cal100 = 33,
                Cal50 = 16.50,
                Cal10 = 3.3
            });
            produces.Add(new Produce
            {
                Name = "Mazare verde boabe",
                Cal100 =96,
                Cal50 =	48,
                Cal10 =	9.6   
             }); 
            produces.Add(new Produce
            {
                Name = "Morcov",
                Cal100 =45,
                Cal50 =	22.50,
                Cal10 =	4.5  
               });
            produces.Add(new Produce
            {
                Name = "Ridichi",
                Cal100 =22,
                Cal50 = 11.00,
                Cal10 = 2.2 
              });
            produces.Add(new Produce
            {
                Name = "Spanac",
                Cal100 =25,
                Cal50 = 12.50,
                Cal10 =	2.5 
              });
            produces.Add(new Produce
            {
                Name = "Afine",
                Cal100 =66,
                Cal50 = 33,
                Cal10 = 6.6
             });
           produces.Add(new Produce
            {
                Name = "Caise",
                Cal100 =58 ,
                Cal50 =	29,
                Cal10 =	5.8  
             });
           produces.Add(new Produce
            {
                Name = "Capsune",
                Cal100 =43 ,
                Cal50 = 21.50,
                Cal10 = 4.3
             });
           produces.Add(new Produce
            {
                Name = "Cirese",
                Cal100 =82,
                Cal50 =	41,
                Cal10 =	8.2   
            });
          produces.Add(new Produce
            {
                Name = "Grapefruit",
                Cal100 =38,
                Cal50 =	19,
                Cal10 = 3.8  
            });
          produces.Add(new Produce
            {
                Name = "Gutui",
                Cal100 =66,
                Cal50 =	33,
                Cal10 =	6.6   
            });
          produces.Add(new Produce
            {
                Name = "Lamai",
                Cal100 = 30,
                Cal50 = 15,
                Cal10 =	3 
            });
            produces.Add(new Produce
            {
                Name = "Mandarine",
                Cal100 =40,
                Cal50 =	20,
                Cal10 =	4   
            });
            produces.Add(new Produce
            {
                Name = "Nectarine",
                Cal100 = 56,
                Cal50 =	28,
                Cal10 =	5.6  
           }); 
            produces.Add(new Produce
            {
                Name = "Pepene galben",
                Cal100 =23,
                Cal50 =	11.50,
                Cal10 =	2.3   
            });
            produces.Add(new Produce
            {
                Name = "Pepene verde",
                Cal100 = 29,
                Cal50 =	14.50,
                Cal10 =	2.9  
           }); 
           produces.Add(new Produce
            {
                Name = "Prune",
                Cal100 = 74,
                Cal50 =37,
                Cal10 =	7.4  
           }); 
           produces.Add(new Produce
            {
                Name = "Struguri",
                Cal100 =100,
                Cal50 =	50,
                Cal10 =	10  
           }); 
            produces.Add(new Produce
            {
                Name = "Zmeura",
                Cal100 =67,
                Cal50 =	33.50,
                Cal10 =	6.7   
            });
        }
        public int ListSize => produces.Count;
        public double GetCalories(int ID, int count)
        {
            Produce produce = produces[ID];
            switch (count)
            {
                case 100:
                    return produce.Cal100;
                case 50:
                    return produce.Cal50;
                case 10:
                    return produce.Cal10;
                default:
                    return -1;
            }
        }
        public string GetName(int ID) => produces[ID].Name;
    }
}
