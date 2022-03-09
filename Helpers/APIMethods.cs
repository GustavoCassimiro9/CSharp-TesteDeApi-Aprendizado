namespace AutomacaoPetStore.Helpers
{
    public class APIMethods
    {
        public static string StoreOrder
        {
            get
            {
                return $"{CustomConfigurationProvider.GetKey("petStoreService-baseUrl")}store/order/";
            }
        }

        public static string StoreInventory
        {
            get
            {
                return $"{CustomConfigurationProvider.GetKey("petStoreService-baseUrl")}store/inventory";
            }
        }

        public static string UserName
        {
            get
            {
                return $"{CustomConfigurationProvider.GetKey("petStoreService-baseUrl")}user/";
                    
            }
        }
    }

}
