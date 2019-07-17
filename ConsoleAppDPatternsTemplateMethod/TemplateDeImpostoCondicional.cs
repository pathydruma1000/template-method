﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppDPatternsTemplateMethod
{
    abstract class TemplateDeImpostoCondicional : Imposto
    {
        public double Calcula(Orcamento orcamento)
        { 
            if (DeveUsarMaximaTaxacao(orcamento))
            {
                return MaximaTaxacao(orcamento);
            }
            else
            {
                return MinimaTaxacao(orcamento);
            }
        }

        protected abstract bool DeveUsarMaximaTaxacao(Orcamento orcamento);
        protected abstract double MaximaTaxacao(Orcamento orcamento);
        protected abstract double MinimaTaxacao(Orcamento orcamento);
    }
}
