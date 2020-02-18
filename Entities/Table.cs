using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.Mapping;
using System.Data.Linq;

namespace CourseWork_Vostrikov.Entities
{
    [Table(Name="Breed")]
    public class Breed
    {
        [Column(Name = "ID", IsPrimaryKey = true, IsDbGenerated = true)]
        public int ID { get; set; }

        [Column(Name = "BreedName")]
        public string BreedName { get; set; }
    }

    [Table(Name = "Owners")]
    public class Owners
    {
        [Column(Name = "ID", IsPrimaryKey = true, IsDbGenerated = true)]
        public int ID { get; set; }

        [Column(Name = "OwnerName")]
        public string OwnerName { get; set; }

        [Column(Name = "Adress")]
        public string Adress { get; set; }

        [Column(Name = "PhoneNumber")]
        public string PhoneNumber { get; set; }
    }

    [Table(Name = "Dog")]
    public class Dog
    {
        [Column(Name = "ID", IsPrimaryKey = true, IsDbGenerated = true)]
        public int ID { get; set; }

        [Column(Name = "IDBreed")]
        public int? IDBreed { get; set; }
        private EntityRef<Breed> _FK_IDBreed;

        [Association(ThisKey = "IDBreed", Storage = "_FK_IDBreed")]

        public Breed Breed
        {
            get => _FK_IDBreed.Entity;
            internal set
            {
                _FK_IDBreed.Entity = value;
                IDBreed = value.ID;
            }
        }

        [Column(Name = "DogName")]
        public string DogName { get; set; }

        [Column(Name = "Color")]
        public string Color { get; set; }

        [Column(Name = "Gender")]
        public string Gender { get; set; }

        [Column(Name = "Height")]
        public double? Height { get; set; }

        [Column(Name = "DateBorn")]
        public DateTime? DateBorn { get; set; }


        [Column(Name = "IDMother")]
        public int? IDMother { get; set; }
        private EntityRef<Dog> _FK_IDMother;

        [Association(ThisKey = "IDMother", Storage = "_FK_IDMother")]

        public Dog Mother
        {
            get => _FK_IDMother.Entity;
            internal set
            {
                _FK_IDMother.Entity = value;
                IDMother = value.ID;
            }
        }

        [Column(Name = "IDFather")]
        public int? IDFather { get; set; }
        private EntityRef<Dog> _FK_IDFather;

        [Association(ThisKey = "IDFather", Storage = "_FK_IDFather")]

        public Dog Father
        {
            get => _FK_IDFather.Entity;
            internal set
            {
                _FK_IDFather.Entity = value;
                IDFather = value.ID;
            }
        } 
    }
        [Table(Name = "OwnerDog")]
        public class OwnerDog
        {
            [Column(Name = "IDDog", IsPrimaryKey = true)]
            public int IDDog { get; set; }

            private EntityRef<Dog> _FK_IDDog;

            [Association(ThisKey = "IDDog", Storage = "_FK_IDDog")]

            public Dog Dogs
            {
                get => _FK_IDDog.Entity;
                internal set
                {
                    _FK_IDDog.Entity = value;
                    IDDog = value.ID;
                }
            }

            [Column(Name = "IDOwner", IsPrimaryKey = true)]
            public int IDOwner { get; set; }

            private EntityRef<Owners> _FK_IDOwner;

            [Association(ThisKey = "IDOwner", Storage = "_FK_IDOwner")]
            

            public Owners OwnerID
            {
                get => _FK_IDOwner.Entity;
                internal set
                {
                    _FK_IDOwner.Entity = value;
                    IDOwner = value.ID;
                }
            }
        }

}
