using CourseWork_Vostrikov.Entities;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CourseWork_Vostrikov.Entities.Dog;

namespace CourseWork_Vostrikov.dbHelper
{
    public class SQL
    {
        private static string _connectionString =
           @"Data Source=.\SQLEXPRESS;Initial Catalog=CourseWork_Vostrikov;Integrated Security=True";



        private readonly DataContext Dc = new DataContext(_connectionString);

        public Table<Breed> GetBreedTable() => Dc.GetTable<Breed>();

        public Table<Owners> GetOwnersTable() => Dc.GetTable<Owners>();

        public Table<Dog> GetDogTable() => Dc.GetTable<Dog>();

        public Table<OwnerDog> GetOwnerDogTable() => Dc.GetTable<OwnerDog>();

        public void AddBreed(Breed breed)
        {
            GetBreedTable().InsertOnSubmit(breed);
            Dc.SubmitChanges();
        }

        public void AddOwner(Owners owner)
        {
            GetOwnersTable().InsertOnSubmit(owner);
            Dc.SubmitChanges();
        }

        public void AddDog(Dog dog)
        {
            GetDogTable().InsertOnSubmit(dog);
            Dc.SubmitChanges();
        }

        public void AddOwnerDog(OwnerDog ownerdog)
        {
            Dog dog = GetDogTable().Where(x => x.ID == ownerdog.IDDog).First();
            ownerdog.Dogs = dog;
            Owners owner = GetOwnersTable().Where(y => y.ID == ownerdog.IDOwner).First();
            ownerdog.OwnerID = owner;
            GetOwnerDogTable().InsertOnSubmit(ownerdog);
            Dc.SubmitChanges();
        }

        public void Update()
        {
            Dc.SubmitChanges();
        }


        public void DeleteBreed(Breed breed)
        {
            GetBreedTable().DeleteOnSubmit(breed);
            Dc.SubmitChanges();
        }

        public void DeleteOwner(Owners owner)
        {
            GetOwnersTable().DeleteOnSubmit(owner);
            Dc.SubmitChanges();
        }

        public void DeleteDog(Dog dog)
        {
            GetDogTable().DeleteOnSubmit(dog);
            Dc.SubmitChanges();
        }

        public void DeleteOwnerDog(OwnerDog ownerdog)
        {
            GetOwnerDogTable().DeleteOnSubmit(ownerdog);
            Dc.SubmitChanges();
        }


        public IQueryable GetNamewithBreed()
        {
            return
                from Dog in GetDogTable()
                join Breed in GetBreedTable() on Dog.IDBreed equals Breed.ID
                select new { Dog.DogName, Breed.BreedName };
        }

        public IQueryable GetOwnerNamewithDogname()
        {
            return
                from OwnerDog in GetOwnerDogTable()
                join Dog in GetDogTable() on OwnerDog.IDDog equals Dog.ID
                join Owners in GetOwnersTable() on OwnerDog.IDOwner equals Owners.ID
                select new { Owners.OwnerName, Dog.DogName };
        }

        public IQueryable GetOwnerNamewithBreename()
        {

            return
                from OwnerDog in GetOwnerDogTable()
                join Owners in GetOwnersTable() on OwnerDog.IDOwner equals Owners.ID
                join Dog in GetDogTable() on OwnerDog.IDDog equals Dog.ID
                join Breed in GetBreedTable() on OwnerDog.IDDog equals Breed.ID
                select new { Owners.OwnerName, Breed.BreedName };
        }

        public IQueryable updatingBreed()
        {
            return
                from Breed in GetBreedTable()
                select new {Breed.ID, Breed.BreedName };
        }

        public IQueryable updatingOwners()
        {
            return
                from Owners in GetOwnersTable()
                select new { Owners.ID, Owners.OwnerName, Owners.Adress, Owners.PhoneNumber};
        }

        public IQueryable updatingDog()
        {
            return
                from Dog in GetDogTable()
                select new {Dog.ID, Dog.IDBreed, Dog.DogName, Dog.Color, Dog.Gender, Dog.Height, Dog.DateBorn, Dog.IDMother, Dog.IDFather  };
        }

        public IQueryable updatingOwnerDog()
        {
            return
                from OwnerDog in GetOwnerDogTable()
                select new { OwnerDog.IDDog, OwnerDog.IDOwner};
        }

    }
}
