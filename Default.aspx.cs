using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }
    protected void Button1_Click(object sender, EventArgs e)
    {


        // Decision makers

        String[] makers = new String[]{"D1","D2"};

        // count number of decision makers
        int dnum = makers.Length;

        //Consider Alternatives, attributes and weights

        // Example of 5 alternatives , (A1,A2,A3,A4,A5) and 5 attributeS  (C1,C2,C3,C4,C5)

        // Comittee of 1 DMs (D1,D2)
        
       // Step 2

        //Decision Maker1 Fuzzy ratings for each alternatives with respect to each criteria

        // for alternative1
        double[] d1alt1wc1 = new double[] { 9, 10, 10 };
        double[] d1alt1wc2 = new double[] { 7, 9, 10 };
        double[] d1alt1wc3 = new double[] { 5, 7, 9 };
        double[] d1alt1wc4 = new double[] { 3, 5, 7 };
        double[] d1alt1wc5 = new double[] { 1, 3, 5 };
        // for alternative2
        double[] d1alt2wc1 = new double[] { 7, 9, 10 };
        double[] d1alt2wc2 = new double[] { 5, 7, 9 };
        double[] d1alt2wc3 = new double[] { 3, 5, 7 };
        double[] d1alt2wc4 = new double[] { 1, 3, 5 };
        double[] d1alt2wc5 = new double[] { 1, 3, 5 };
               // for alternative3
        double[] d1alt3wc1 = new double[] { 5, 7, 9 };
        double[] d1alt3wc2 = new double[] { 3, 5, 7};
        double[] d1alt3wc3 = new double[] { 3, 5, 7 };
        double[] d1alt3wc4 = new double[] { 1, 3, 5 };
        double[] d1alt3wc5 = new double[] { 1, 3, 5 };
        // for alternative4
        double[] d1alt4wc1 = new double[] { 9, 10, 10 };
        double[] d1alt4wc2 = new double[] { 1, 3, 5 };
        double[] d1alt4wc3 = new double[] { 1, 3, 5 };
        double[] d1alt4wc4 = new double[] { 3, 5, 7};
        double[] d1alt4wc5 = new double[] { 1, 3, 5 };
        // for alternative5
        double[] d1alt5wc1 = new double[] { 1, 3, 5 };
        double[] d1alt5wc2 = new double[] { 1, 3, 5 };
        double[] d1alt5wc3 = new double[] { 5, 7, 9 };
        double[] d1alt5wc4 = new double[] { 1, 3, 5 };
        double[] d1alt5wc5 = new double[] { 1, 3, 5 };
        //
        //Decision Maker2 Fuzzy ratings for each alternatives with respect to each criteria

        // for alternative1
        double[] d2alt1wc1 = new double[] { 1, 3, 5};
        double[] d2alt1wc2 = new double[] { 7, 9, 10 };
        double[] d2alt1wc3 = new double[] { 3, 5, 7};
        double[] d2alt1wc4 = new double[] { 3, 5, 7 };
        double[] d2alt1wc5 = new double[] { 9, 10, 10};
        // for alternative2
        double[] d2alt2wc1 = new double[] { 1, 3, 5 };
        double[] d2alt2wc2 = new double[] { 1, 3, 5 };
        double[] d2alt2wc3 = new double[] { 3, 5, 7 };
        double[] d2alt2wc4 = new double[] { 7, 9, 10 };
        double[] d2alt2wc5 = new double[] { 1, 3, 5 };

        // for alternative3
        double[] d2alt3wc1 = new double[] { 5, 7, 9 };
        double[] d2alt3wc2 = new double[] { 1, 3, 5 };
        double[] d2alt3wc3 = new double[] { 3, 5, 7 };
        double[] d2alt3wc4 = new double[] { 5, 7, 9 };
        double[] d2alt3wc5 = new double[] { 1, 3, 5 };
        // for alternative4
        double[] d2alt4wc1 = new double[] { 9, 10, 10 };
        double[] d2alt4wc2 = new double[] { 1, 3, 5 };
        double[] d2alt4wc3 = new double[] { 9, 10, 10 };
        double[] d2alt4wc4 = new double[] { 3, 5, 7 };
        double[] d2alt4wc5 = new double[] { 1, 3, 5 };
        // for alternative5
        double[] d2alt5wc1 = new double[] { 5, 7, 9};
        double[] d2alt5wc2 = new double[] { 1, 3, 5 };
        double[] d2alt5wc3 = new double[] { 5, 7, 9 };
        double[] d2alt5wc4 = new double[] { 1, 3, 5 };
        double[] d2alt5wc5 = new double[] { 5, 7, 9 };
        //
        // 1.Define importance weights for all attributes and....

        // Decision maker 1 wieghts for criteria

        double[] d1wc1 = new double[] { 9, 10, 10 };//Very Good
        double[] d1wc2 = new double[] { 7, 9, 10 };//Good
        double[] d1wc3 = new double[] { 5, 7, 9 };//Medium Good
        double[] d1wc4 = new double[] { 3, 5, 7 };//Fair
        double[] d1wc5 = new double[] { 1, 3, 3 }; //Medium Poor
        //
        // Decision maker 2 wieghts for criteria

        double[] d2wc1 = new double[] { 7, 9, 10 };//Very Good
        double[] d2wc2 = new double[] { 9, 10, 10 };//Good
        double[] d2wc3 = new double[] { 3, 5, 7 };//Medium Good
        double[] d2wc4 = new double[] { 5, 7, 9 };//Fair
        double[] d2wc5 = new double[] { 1, 3, 3 }; //Medium Poor
        // number of decision makers
        int K = dnum;


        // Step 3: -- 

        // Determine Aggregate fuzzy rating of alternatives

        // Alternative 1

        double[] aggalt1wc1 = new double[] { (d1alt1wc1[0] + d2alt1wc1[0])/K, (d1alt1wc1[1] + d2alt1wc1[1])/K, (d1alt1wc1[2] + d2alt1wc1[2])/K };
        double[] aggalt1wc2 = new double[] { (d1alt1wc2[0] + d2alt1wc2[0]) / K, (d1alt1wc2[1] + d2alt1wc2[1]) / K, (d1alt1wc2[2] + d2alt1wc2[2]) / K };
        double[] aggalt1wc3 = new double[] { (d1alt1wc3[0] + d2alt1wc3[0]) / K, (d1alt1wc3[1] + d2alt1wc3[1]) / K, (d1alt1wc3[2] + d2alt1wc3[2]) / K };
        double[] aggalt1wc4 = new double[] { (d1alt1wc4[0] + d2alt1wc4[0]) / K, (d1alt1wc4[1] + d2alt1wc4[1]) / K, (d1alt1wc4[2] + d2alt1wc4[2]) / K };
        double[] aggalt1wc5 = new double[] { (d1alt1wc5[0] + d2alt1wc5[0]) / K, (d1alt1wc5[1] + d2alt1wc5[1]) / K, (d1alt1wc5[2] + d2alt1wc5[2]) / K };
        // for alternative2
        double[] aggalt2wc1 = new double[] { (d1alt2wc1[0] + d2alt2wc1[0]) / K, (d1alt2wc1[1] + d2alt2wc1[1]) / K, (d1alt2wc1[2] + d2alt2wc1[2]) / K };
        double[] aggalt2wc2 = new double[] { (d1alt2wc2[0] + d2alt2wc2[0]) / K, (d1alt2wc2[1] + d2alt2wc2[1]) / K, (d1alt2wc2[2] + d2alt2wc2[2]) / K };
        double[] aggalt2wc3 = new double[] { (d1alt2wc3[0] + d2alt2wc3[0]) / K, (d1alt2wc3[1] + d2alt2wc3[1]) / K, (d1alt2wc3[2] + d2alt2wc3[2]) / K };
        double[] aggalt2wc4 = new double[] { (d1alt2wc4[0] + d2alt2wc4[0]) / K, (d1alt2wc4[1] + d2alt2wc4[1]) / K, (d1alt2wc4[2] + d2alt2wc4[2]) / K };
        double[] aggalt2wc5 = new double[] { (d1alt2wc5[0] + d2alt2wc5[0]) / K, (d1alt2wc5[1] + d2alt2wc5[1]) / K, (d1alt2wc5[2] + d2alt2wc5[2]) / K };
        // for alternative3
        double[] aggalt3wc1 = new double[] { (d1alt3wc1[0] + d2alt3wc1[0]) / K, (d1alt3wc1[1] + d2alt3wc1[1]) / K, (d1alt3wc1[2] + d2alt3wc1[2]) / K };
        double[] aggalt3wc2 = new double[] { (d1alt3wc2[0] + d2alt3wc2[0]) / K, (d1alt3wc2[1] + d2alt3wc2[1]) / K, (d1alt3wc2[2] + d2alt3wc2[2]) / K };
        double[] aggalt3wc3 = new double[] { (d1alt3wc3[0] + d2alt3wc3[0]) / K, (d1alt3wc3[1] + d2alt3wc3[1]) / K, (d1alt3wc3[2] + d2alt3wc3[2]) / K };
        double[] aggalt3wc4 = new double[] { (d1alt3wc4[0] + d2alt3wc4[0]) / K, (d1alt3wc4[1] + d2alt3wc4[1]) / K, (d1alt3wc4[2] + d2alt3wc4[2]) / K };
        double[] aggalt3wc5 = new double[] { (d1alt3wc5[0] + d2alt3wc5[0]) / K, (d1alt3wc5[1] + d2alt3wc5[1]) / K, (d1alt3wc5[2] + d2alt3wc5[2]) / K };
        // for alternative4
        double[] aggalt4wc1 = new double[] { (d1alt4wc1[0] + d2alt4wc1[0]) / K, (d1alt4wc1[1] + d2alt4wc1[1]) / K, (d1alt4wc1[2] + d2alt3wc1[2]) / K };
        double[] aggalt4wc2 = new double[] { (d1alt4wc2[0] + d2alt4wc2[0]) / K, (d1alt4wc2[1] + d2alt4wc2[1]) / K, (d1alt4wc2[2] + d2alt3wc2[2]) / K };
        double[] aggalt4wc3 = new double[] { (d1alt4wc3[0] + d2alt4wc3[0]) / K, (d1alt4wc3[1] + d2alt4wc3[1]) / K, (d1alt4wc3[2] + d2alt3wc3[2]) / K };
        double[] aggalt4wc4 = new double[] { (d1alt4wc4[0] + d2alt4wc4[0]) / K, (d1alt4wc4[1] + d2alt4wc4[1]) / K, (d1alt4wc4[2] + d2alt3wc4[2]) / K };
        double[] aggalt4wc5 = new double[] { (d1alt4wc5[0] + d2alt4wc5[0]) / K, (d1alt4wc5[1] + d2alt4wc5[1]) / K, (d1alt4wc5[2] + d2alt3wc5[2]) / K };
        // for alternative5
        double[] aggalt5wc1 = new double[] { (d1alt5wc1[0] + d2alt5wc1[0]) / K, (d1alt5wc1[1] + d2alt5wc1[1]) / K, (d1alt5wc1[2] + d2alt5wc1[2]) / K };
        double[] aggalt5wc2 = new double[] { (d1alt5wc2[0] + d2alt5wc2[0]) / K, (d1alt5wc2[1] + d2alt5wc2[1]) / K, (d1alt5wc2[2] + d2alt5wc2[2]) / K };
        double[] aggalt5wc3 = new double[] { (d1alt5wc3[0] + d2alt5wc3[0]) / K, (d1alt5wc3[1] + d2alt5wc3[1]) / K, (d1alt5wc3[2] + d2alt5wc3[2]) / K };
        double[] aggalt5wc4 = new double[] { (d1alt5wc4[0] + d2alt5wc4[0]) / K, (d1alt5wc4[1] + d2alt5wc4[1]) / K, (d1alt5wc4[2] + d2alt5wc4[2]) / K };
        double[] aggalt5wc5 = new double[] { (d1alt5wc5[0] + d2alt5wc5[0]) / K, (d1alt5wc5[1] + d2alt5wc5[1]) / K, (d1alt5wc5[2] + d2alt5wc5[2]) / K };
        

                
        // Determine Aggregate fuzzy weight of attributes/criteria


        double[] aggwc1 = new double[] { (d1wc1[0] + d2wc1[0]) / K, (d1wc1[1] + d2wc1[1]) / K, (d1wc1[2] + d2wc1[2]) / K };
        double[] aggwc2 = new double[] { (d1wc2[0] + d2wc1[0]) / K, (d1wc2[1] + d2wc2[1]) / K, (d1wc2[2] + d2wc2[2]) / K };
        double[] aggwc3 = new double[] { (d1wc3[0] + d2wc1[0]) / K, (d1wc3[1] + d2wc3[1]) / K, (d1wc3[2] + d2wc3[2]) / K };
        double[] aggwc4 = new double[] { (d1wc4[0] + d2wc1[0]) / K, (d1wc4[1] + d2wc4[1]) / K, (d1wc4[2] + d2wc4[2]) / K };
         double[] aggwc5 = new double[] { (d1wc5[0] + d2wc1[0]) / K, (d1wc5[1] + d2wc5[1]) / K, (d1wc5[2] + d2wc5[2]) / K };

         // Step 4 - perform scaling
        // Scaling the aggregate fuzz ratings for alternatives only--// compute scaling only for benefits j E B

         double xjmax, xjmin;

        // calculate maxxij3 = xjmax


         double[] xij3 = new double[] { aggalt1wc1[2], aggalt1wc2[2], aggalt1wc3[2], aggalt1wc4[2], aggalt1wc5[2],
                                      aggalt2wc1[2], aggalt2wc2[2], aggalt2wc3[2],aggalt2wc4[2],aggalt2wc5[2],
                                      aggalt3wc1[2],aggalt3wc2[2],aggalt3wc3[2],aggalt3wc4[2],aggalt3wc5[2] ,
                                      aggalt4wc1[2],aggalt4wc2[2],aggalt4wc3[2],aggalt4wc4[2],aggalt4wc5[2],
                                      aggalt5wc1[2], aggalt5wc2[2], aggalt5wc3[2], aggalt5wc4[2], aggalt5wc5[2]
         };

         xjmax = xij3.Max();

        // calcualte min xij1 = xjmin

         double[] xij1 = new double[] { aggalt1wc1[0], aggalt1wc2[0], aggalt1wc3[0], aggalt1wc4[0], aggalt1wc5[0],
                                      aggalt2wc1[0], aggalt2wc2[0], aggalt2wc3[0],aggalt2wc4[0],aggalt2wc5[0],
                                      aggalt3wc1[0],aggalt3wc2[0],aggalt3wc3[0],aggalt3wc4[0],aggalt3wc5[0] ,
                                      aggalt4wc1[0],aggalt4wc2[0],aggalt4wc3[0],aggalt4wc4[0],aggalt4wc5[0],
                                      aggalt5wc1[0], aggalt5wc2[0], aggalt5wc3[0], aggalt5wc4[0], aggalt5wc5[0]
         };

         xjmin = xij1.Min();

        //denominator

         double denom = xjmax - xjmin;

        

         // Alternative 1

         double[] saggalt1wc1 = new double[] { (aggalt1wc1[0]-xjmin )/ denom, (aggalt1wc1[1]-xjmin) / denom, (aggalt1wc1[2]-xjmin) / denom };
         double[] saggalt1wc2 = new double[] { (aggalt1wc2[0] - xjmin) / denom, (aggalt1wc2[1] - xjmin) / denom, (aggalt1wc2[2] - xjmin) / denom };
         double[] saggalt1wc3 = new double[] { (aggalt1wc3[0] - xjmin) / denom, (aggalt1wc3[1] - xjmin) / denom, (aggalt1wc3[2] - xjmin) / denom };
         double[] saggalt1wc4 = new double[] { (aggalt1wc4[0]-xjmin )/ denom, (aggalt1wc4[1]-xjmin) / denom, (aggalt1wc4[2]-xjmin) / denom};
         double[] saggalt1wc5 = new double[] { (aggalt1wc5[0]-xjmin )/ denom, (aggalt1wc5[1]-xjmin) / denom, (aggalt1wc5[2]-xjmin) / denom};
         // for alternative2
         double[] saggalt2wc1 = new double[] { (aggalt2wc1[0]-xjmin )/ denom, (aggalt2wc1[1]-xjmin) / denom, (aggalt2wc1[2]-xjmin) / denom};
         double[] saggalt2wc2 = new double[] {(aggalt2wc2[0]-xjmin )/ denom, (aggalt2wc2[1]-xjmin) / denom, (aggalt2wc2[2]-xjmin) / denom };
         double[] saggalt2wc3 = new double[] {(aggalt2wc3[0]-xjmin )/ denom, (aggalt2wc3[1]-xjmin) / denom, (aggalt2wc3[2]-xjmin) / denom };
         double[] saggalt2wc4 = new double[] {(aggalt2wc4[0]-xjmin )/ denom, (aggalt2wc4[1]-xjmin) / denom, (aggalt2wc4[2]-xjmin) / denom};
         double[] saggalt2wc5 = new double[] { (aggalt2wc5[0]-xjmin )/ denom, (aggalt2wc5[1]-xjmin) / denom, (aggalt2wc5[2]-xjmin) / denom };
         // for alternative3
         double[] saggalt3wc1 = new double[] { (aggalt3wc1[0]-xjmin )/ denom, (aggalt3wc1[1]-xjmin) / denom, (aggalt3wc1[2]-xjmin) / denom };
         double[] saggalt3wc2 = new double[] { (aggalt3wc2[0]-xjmin )/ denom, (aggalt3wc2[1]-xjmin) / denom, (aggalt3wc2[2]-xjmin) / denom};
         double[] saggalt3wc3 = new double[] { (aggalt3wc3[0]-xjmin )/ denom, (aggalt3wc3[1]-xjmin) / denom, (aggalt3wc3[2]-xjmin) / denom };
         double[] saggalt3wc4 = new double[] { (aggalt3wc4[0]-xjmin )/ denom, (aggalt3wc4[1]-xjmin) / denom, (aggalt3wc4[2]-xjmin) / denom};
         double[] saggalt3wc5 = new double[] { (aggalt3wc5[0]-xjmin )/ denom, (aggalt3wc5[1]-xjmin) / denom, (aggalt3wc5[2]-xjmin) / denom };
         // for alternative4
         double[] saggalt4wc1 = new double[] { (aggalt4wc1[0]-xjmin )/ denom, (aggalt4wc1[1]-xjmin) / denom, (aggalt4wc1[2]-xjmin) / denom };
         double[] saggalt4wc2 = new double[] { (aggalt4wc2[0]-xjmin )/ denom, (aggalt4wc2[1]-xjmin) / denom, (aggalt4wc2[2]-xjmin) / denom  };
         double[] saggalt4wc3 = new double[] { (aggalt4wc3[0]-xjmin )/ denom, (aggalt4wc3[1]-xjmin) / denom, (aggalt4wc3[2]-xjmin) / denom };
         double[] saggalt4wc4 = new double[] { (aggalt4wc4[0]-xjmin )/ denom, (aggalt4wc4[1]-xjmin) / denom, (aggalt4wc4[2]-xjmin) / denom  };
         double[] saggalt4wc5 = new double[] { (aggalt4wc5[0]-xjmin )/ denom, (aggalt4wc5[1]-xjmin) / denom, (aggalt4wc5[2]-xjmin) / denom  };
         // for alternative5
         double[] saggalt5wc1 = new double[] { (aggalt5wc1[0]-xjmin )/ denom, (aggalt5wc1[1]-xjmin) / denom, (aggalt5wc1[2]-xjmin) / denom  };
         double[] saggalt5wc2 = new double[] { (aggalt5wc2[0]-xjmin )/ denom, (aggalt5wc2[1]-xjmin) / denom, (aggalt5wc2[2]-xjmin) / denom  };
         double[] saggalt5wc3 = new double[] { (aggalt5wc3[0]-xjmin )/ denom, (aggalt5wc3[1]-xjmin) / denom, (aggalt5wc3[2]-xjmin) / denom };
         double[] saggalt5wc4 = new double[] { (aggalt5wc4[0]-xjmin )/ denom, (aggalt5wc4[1]-xjmin) / denom, (aggalt5wc4[2]-xjmin) / denom  };
         double[] saggalt5wc5 = new double[] { (aggalt5wc5[0]-xjmin )/ denom, (aggalt5wc5[1]-xjmin) / denom, (aggalt5wc5[2]-xjmin) / denom };
        




        // Step 5: -- construct the weighted normalized fuzzy decision matrixs z = m x n  // represent arrays in 5x5 matrix form   zij












    }
   
}
