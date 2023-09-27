﻿using AutoMapper;
using Core.Models;
using Database.Repositories;

namespace Business.Domains
{
    public class FinanceDomain
    {
        private readonly IFinanceRepository financeRepository;
        private readonly IMapper mapper;

        public FinanceDomain(IFinanceRepository financeRepository, IMapper mapper)
        {
            this.financeRepository = financeRepository;
            this.mapper = mapper;
        }

        public async Task InsertDataFin(FinData finDataToAdd)
        {
            await financeRepository.AddAsync(mapper.Map<FinData, Database.Models.FinData>(finDataToAdd));
        }

        public async Task ShowAllFinData()
        {
            var datas = await this.financeRepository.GetAllAsync();
            foreach (var data in datas)
            {
                await financeRepository.GetAsync(data.Id);
                Console.WriteLine($"{data.Id} {data.ENVIRO} {data.REALIZED}");
            }

        }

        public async Task GetFinData(int id)
        {
            var data = await this.financeRepository.GetAsync(id);
            Console.WriteLine($"{data.Id} {data.ENVIRO} {data.REALIZED}");
        }

        public async Task Delete(int id)
        {
            try
            {
                var existingData = await this.financeRepository.GetAsync(id);
                await this.financeRepository.DeleteAsync(existingData);
                Console.WriteLine($"{existingData.Id} {existingData.ENVIRO} {existingData.REALIZED} DELETED");
            }
            catch (NullReferenceException)
            {
                return;
            }
        }

        public async Task Update(FinData finDataToUpdate)
        {
            //await this.financeRepository.UpdateAsync();
            Console.WriteLine($"{finDataToUpdate.Id} {finDataToUpdate.ENVIRO} {finDataToUpdate.REALIZED} UPDATED");
        }
    }
}