using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using HJNKoyil.Models;

namespace HJNKoyil.BusinessLogic
{
    public class Individuals
    {
        KoyilDbContext _dbContext = new KoyilDbContext();
        #region	GetIndividuals
        public IEnumerable<Individual> GetIndividuals()
        {
            //Write Logic to get Individual here
            return _dbContext.Individual.ToList();
        }
        public IEnumerable<Individual> GetIndividuals(string sSearch)
        {
            //Write Logic to get Individual here
            return _dbContext.Individual.Where (o=>o.FullName.Contains(sSearch)).ToList();
        }

        #endregion

        #region	CreateIndividual
        public void CreateIndividual(Individual individual)
        {
            //Write Logic to Create Individualhere
            _dbContext.Individual.Add(individual);
            _dbContext.SaveChanges();
        }

        public void UpdateIndividual(Individual individual)
        {
            //Write Logic to Update Individualhere
            _dbContext.Entry(individual).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }
        #endregion

        #region	GetIndividual
        public Individual GetIndividual(System.Int32 pID)
        {
            //Write Logic to get Individual here
            return _dbContext.Individual.SingleOrDefault(x => x.Id == pID);
        }
        #endregion

        #region	DeleteIndividual
        public void DeleteIndividual(System.Int32 pID)
        {
            //Write Logic to Delete Individualhere
            Individual individual = _dbContext.Individual.SingleOrDefault(x => x.Id == pID);
            _dbContext.Individual.Remove(individual);
            _dbContext.SaveChanges();
        }
        #endregion
    }
}
