﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowCoupling.JeitoErrado
{
    public class ItemPedido
    {
        public ItemPedido(int id, int qtd)
        {
            Produto = new Produto(id);
            Qtd = qtd;
        }
        public Produto Produto { get; private set; }
        public int Qtd { get; private set; }

        public void AddQtd(int qtd)
        {
            Qtd += qtd;
        }
        public decimal TotalParcial()
        {
            return Produto.Preco * Qtd;
        }
    }
}
