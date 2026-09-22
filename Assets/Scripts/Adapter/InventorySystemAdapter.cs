using UnityEngine;
using System.Collections.Generic;
using Chapter.Adapter;

namespace Chapter.Adpater
{
    public class InventorySystemAdapter : InventorySystem, IInventorySystem
    {
        private List<InventoryItem> _cloudInventory;

        public void AddItem(InventoryItem item, SaveLocation location)
        {
            if (location == SaveLocation.Cloud)
                AddItem(item);

            if (location == SaveLocation.Local)
                Debug.Log("Adding item to local drive");

            if (location == SaveLocation.Both)
                Debug.Log("Adding item to local drive and on the cloud");
        }

        public List<InventoryItem> GetInventory(SaveLocation location)
        {
            Debug.Log("Get inventory from local/cloud/both");
            return new List<InventoryItem>();
        }

        public void RemoveItem(InventoryItem item, SaveLocation location)
        {
            Debug.Log("Remove inventory from local/cloud/both");
        }

        public void SyncInventories()
        {
            var _cloudInventory = GetInventory();

            Debug.Log("Synchronizing local drive and cloud inventories");
        }
    }
}
