using UnityEngine.Purchasing;
using UnityEngine;

public class IAPManager : MonoBehaviour, IStoreListener
{
    private IStoreController storeController;

    void Start()
    {
        var builder = ConfigurationBuilder.Instance(StandardPurchasingModule.Instance());
        builder.AddProduct("coins_pack_1", ProductType.Consumable);
        UnityPurchasing.Initialize(this, builder);
    }

    public void OnInitialized(IStoreController controller, IExtensionProvider extensions)
    {
        storeController = controller;
        Debug.Log("IAP Initialized.");
    }

    public void BuyProduct(string productId)
    {
        if (storeController != null)
            storeController.InitiatePurchase(productId);
    }

    public void OnPurchaseComplete(Product product)
    {
        Debug.Log("Purchase Complete: " + product.definition.id);
    }

    public void OnPurchaseFailed(Product product, PurchaseFailureReason failureReason)
    {
        Debug.Log("Purchase Failed: " + failureReason);
    }

    public void OnInitializeFailed(InitializationFailureReason error) { }
}
