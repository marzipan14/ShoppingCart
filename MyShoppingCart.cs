using System;

namespace MyShoppingCart
{
    class ShoppingCart
    {
        public static void main (string[] args)
        {
            Checkout checkout = new Checkout();
            int totalPrice = checkout.ConsumeCart();
            if (totalPrice == -1)
            {
                Console.WriteLine("The operation has failed.");
            }
            else
            {
                Console.WriteLine($"The total price is: {totalPrice}");
            }
        }

    }
}
