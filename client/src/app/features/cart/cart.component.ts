import { Component, inject } from '@angular/core';
import { CartService } from '../../core/services/cart.service';
import { CartItemComponent } from './cart-item/cart-item.component';
import { OrderSummayComponent } from '../../shared/components/order-summay/order-summay.component';

@Component({
  selector: 'app-cart',
  imports: [
    CartItemComponent,
    OrderSummayComponent
],
  templateUrl: './cart.component.html',
  styleUrl: './cart.component.scss'
})
export class CartComponent {
  cartService = inject(CartService);
}
