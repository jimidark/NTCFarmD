﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Gro.Core.DataModels.PurchasingAgreements;

namespace Gro.Core.Interfaces
{
    public interface IPurchasingAgreementRepository
    {
        Task<Customer> GetCustomerAsync(string customerId);
        Customer GetCustomer(string customerId);

        Task<PriceArea[]> GetPriceAreasAsync();
        Task<string> GetPriceAreaDescAsync(string priceAreaId);
        Task<PriceArea> GetSelectedPriceArea(string customerId);
        //Task<PricePeriod[]> GetPricePeriodsForStorageAgreementsAsync(string customerId, string areaId);
        Task<StorageAgreement[]> GetStorageAgreementsForPriceProtectionAsync(string customerId);

        //Task<PricePeriod[]> GetPricePeriodsForPriceProtectingStorageAgreementAsync(string areaId,
        //    string productItemId, string grainType);

        Task<AgreementResponse> SaveStorageAgreementAsync(StorageAgreement agreement);
        Task<AgreementResponse> SaveSpotAndForwardAgreementAsync(SpotAndForwardAgreement agreement);
        Task<AgreementResponse> SavePoolAgreement(PoolAgreement agreement);
        Task<AgreementResponse> SavePriceProtectedStorageAgreementAsync(PriceProtectStorageAgreement agreement);
        Task<bool> SaveCustomerFavoritePriceAreaAsync(string customerId, string priceAreaId);

        //Task<bool> UpdateCustomerFavoriteProductitem(string customerId, string priceAreaId, string priceType,
        //    string productItemId, string grainType, bool addFavorite);

        //Task<PricePeriod[]> GetPricePeriodsForPoolAgreementsAsync(string customerId, string priceAreaId);

        //Task<PricePeriod[]> GetPricePeriodsForSpotAndForwardAgreementsAsync(string customerId, string priceAreaId);
        Task<PriceWatch[]> GetPriceWatchAsync(string customerId, string ticket);
        Task<bool> DeletePriceWatchAsync(int id, string ticket);
        Task<PricePeriod[]> GetPricePeriodsGrainPriceAsync(string priceAreaId);
        Task<DryingAgreement> GetDryingAgreementAsync();
        Task<string> SaveDryingAgreementAsync(string customerId);
        DryingAgreement GetDryingAgreement();
        Task<StorageAgreement> GetStorageAgreementValuesForPriceProtectionAsync(string agreementId);

        Task<Dictionary<string, string>> GetPeriodsPriceProtectingStorageAgreementAsync(string priceAreaId,
            string productItemId, string grainType);

        Task<Dictionary<string, string>> GetPeriodsPoolAgreementAsync(string priceAreaId);
        Task<Dictionary<string, string>> GetPeriodsSpotAndForwardAgreementAsync(string priceAreaId);
        Task<Dictionary<string, string>> GetPeriodsStorageAgreementAsync(string priceAreaId);
        Product[] GetProductsSpotAndForwardAgreement(string priceAreaId);
        Task<Product[]> GetGrainTypesSpotAndForwardAgreementAsync(string productItemId, string priceAreaId);

        Task<Product[]> GetProductsPoolAgreementAsync(string priceAgreaId);
        Task<Product[]> GetGrainTypesPoolAgreementAsync(string priceAgreaId, string productItemId);
        Task<Dictionary<int, string>> GetModesOfDeliveryPoolAgreementAsync();

        Task<Product[]> GetProductsStorageAgreementAsync(string priceAgreaId); 
        Task<Product[]> GetGrainTypesStorageAgreementAsync(string priceAgreaId, string productItemId);
        Task<Dictionary<int, string>> GetModesOfDeliveryStorageAgreementAsync();
    }
}