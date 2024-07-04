using System.Collections;
using System.Collections.Generic;
using RPG.Shops;
using UnityEngine;

namespace RPG.UI.Shops
{
    public class ShopUI : MonoBehaviour
    {
        Shopper shopper = null;

        public void Start()
        {
            shopper = GameObject.FindGameObjectWithTag("Player").GetComponent<Shopper>();

            if (shopper == null) return;

            shopper.activeShopChange += ShopChanged;


        }

        public void ShopChanged()
        {

        }

    }
}


