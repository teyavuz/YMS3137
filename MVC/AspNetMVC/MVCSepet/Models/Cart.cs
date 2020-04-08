using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCSepet.Models
{
    public class Cart
    {
        Dictionary<int, CartItem> _myCart = new Dictionary<int, CartItem>();

        public List<CartItem> myCart
        {
            get
            {
                return _myCart.Values.ToList();
            }
        }


        public void AddItem(CartItem item)
        {
            //Eğer parametrede gönderilen ürün varsa ürünü tekrar eklemek yerine o ürünün id'sine ulaşıp adetini 1 kez artırıyoruz.
            if (_myCart.ContainsKey(item.ID))
            {
                _myCart[item.ID].Quantity += 1;
                return;
            }
            else
            {
                _myCart.Add(item.ID, item);
            }

        }
    }
}