using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharpbasics
{
    class AbstratChild : AbstractionKnowledge
    {
public override void AddNumbers(int numA, int numB)
{
    base.numbersadded = numA + numB;
    }

public override void Sumnumbers(int sumA, int sumB)
{
    numbersubtracted = sumA - sumB;
}
    }
}
