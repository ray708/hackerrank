using System;
using System.Collections.Generic;
using System.Text;

namespace Hackerrank
{
    internal class DrawingBook
    {
        public static int pageCount(int n, int p)
        {
            int countEndPage = 0;
            int countInitialPage = 0;
            int endPage = n;
            int actualPageEnd = endPage;
            int actualPagestart = 0;

            if (p == 1 || n == p) return 0;

            if (n % 2 != 0 && n - 1 == p) return 0;
            

            for (int i = actualPageEnd; i > 0; i--)
            {
                if (n % 2 == 0)
                {
                    actualPageEnd = actualPageEnd - 2;
                    countEndPage++;
                    if (actualPageEnd == p || actualPageEnd + 1 == p)
                        i = 0;
                }
                else
                {
                    actualPageEnd = actualPageEnd - 2;
                    countEndPage++;
                    if (actualPageEnd == p || actualPageEnd - 1 == p)
                        i = 0;
                }

            }


            for (int i = 0; i < p; i++)
            {
                actualPagestart = actualPagestart + 2;
                countInitialPage++;
                if (actualPagestart == p || actualPagestart + 1 == p)
                {
                    i = p;
                }

            }

            if (countInitialPage < countEndPage) { return countInitialPage; }
            else { return countEndPage; }

        }
    }

    }
}
