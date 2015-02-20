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

        //Alternative1
         double[] matalt1wc1 = new double[] { saggalt1wc1[0] * aggwc1[0], saggalt1wc1[1] * aggwc1[1], saggalt1wc1[2] * aggwc1[2] };
         double[] matalt1wc2 = new double[] { saggalt1wc2[0] * aggwc2[0], saggalt1wc2[1] * aggwc2[1], saggalt1wc2[2] * aggwc2[2] };
         double[] matalt1wc3 = new double[] { saggalt1wc3[0] * aggwc3[0], saggalt1wc3[1] * aggwc3[1], saggalt1wc3[2] * aggwc3[2] };
         double[] matalt1wc4 = new double[] { saggalt1wc4[0] * aggwc4[0], saggalt1wc4[1] * aggwc4[1], saggalt1wc4[2] * aggwc4[2] };
         double[] matalt1wc5 = new double[] { saggalt1wc5[0] * aggwc5[0], saggalt1wc5[1] * aggwc5[1], saggalt1wc5[2] * aggwc5[2] };
        //alternative2
         double[] matalt2wc1 = new double[] { saggalt2wc1[0] * aggwc1[0], saggalt2wc1[1] * aggwc1[1], saggalt2wc1[2] * aggwc1[2] };
         double[] matalt2wc2 = new double[] { saggalt2wc2[0] * aggwc2[0], saggalt2wc2[1] * aggwc2[1], saggalt2wc2[2] * aggwc2[2] };
         double[] matalt2wc3 = new double[] { saggalt2wc3[0] * aggwc3[0], saggalt2wc3[1] * aggwc3[1], saggalt2wc3[2] * aggwc3[2] };
         double[] matalt2wc4 = new double[] { saggalt2wc4[0] * aggwc4[0], saggalt2wc4[1] * aggwc4[1], saggalt2wc4[2] * aggwc4[2] };
         double[] matalt2wc5 = new double[] { saggalt2wc5[0] * aggwc5[0], saggalt2wc5[1] * aggwc5[1], saggalt2wc5[2] * aggwc5[2] };
        //alternative 3
         double[] matalt3wc1 = new double[] { saggalt3wc1[0] * aggwc1[0], saggalt3wc1[1] * aggwc1[1], saggalt3wc1[2] * aggwc1[2] };
         double[] matalt3wc2 = new double[] { saggalt3wc2[0] * aggwc2[0], saggalt3wc2[1] * aggwc2[1], saggalt3wc2[2] * aggwc2[2] };
         double[] matalt3wc3 = new double[] { saggalt3wc3[0] * aggwc3[0], saggalt3wc3[1] * aggwc3[1], saggalt3wc3[2] * aggwc3[2] };
         double[] matalt3wc4 = new double[] { saggalt3wc4[0] * aggwc4[0], saggalt3wc4[1] * aggwc4[1], saggalt3wc4[2] * aggwc4[2] };
         double[] matalt3wc5 = new double[] { saggalt3wc5[0] * aggwc5[0], saggalt3wc5[1] * aggwc5[1], saggalt3wc5[2] * aggwc5[2] };
        //alternative4
         double[] matalt4wc1 = new double[] { saggalt4wc1[0] * aggwc1[0], saggalt4wc1[1] * aggwc1[1], saggalt4wc1[2] * aggwc1[2] };
         double[] matalt4wc2 = new double[] { saggalt4wc2[0] * aggwc2[0], saggalt4wc2[1] * aggwc2[1], saggalt4wc2[2] * aggwc2[2] };
         double[] matalt4wc3 = new double[] { saggalt4wc3[0] * aggwc3[0], saggalt4wc3[1] * aggwc3[1], saggalt4wc3[2] * aggwc3[2] };
         double[] matalt4wc4 = new double[] { saggalt4wc4[0] * aggwc4[0], saggalt4wc4[1] * aggwc4[1], saggalt4wc4[2] * aggwc4[2] };
         double[] matalt4wc5 = new double[] { saggalt4wc5[0] * aggwc5[0], saggalt4wc5[1] * aggwc5[1], saggalt4wc5[2] * aggwc5[2] };
        //alternative5
         double[] matalt5wc1 = new double[] { saggalt5wc1[0] * aggwc1[0], saggalt5wc1[1] * aggwc1[1], saggalt5wc1[2] * aggwc1[2] };
         double[] matalt5wc2 = new double[] { saggalt5wc2[0] * aggwc2[0], saggalt5wc2[1] * aggwc2[1], saggalt5wc2[2] * aggwc2[2] };
         double[] matalt5wc3 = new double[] { saggalt5wc3[0] * aggwc3[0], saggalt5wc3[1] * aggwc3[1], saggalt5wc3[2] * aggwc3[2] };
         double[] matalt5wc4 = new double[] { saggalt5wc4[0] * aggwc4[0], saggalt5wc4[1] * aggwc4[1], saggalt5wc4[2] * aggwc4[2] };
         double[] matalt5wc5 = new double[] { saggalt5wc5[0] * aggwc5[0], saggalt5wc5[1] * aggwc5[1], saggalt5wc5[2] * aggwc5[2] };


        //Step6: Fuzzy Positive and Negative Ideal alternative


         // calculate zjmax

         double zjmax, zjmin;

         double[] zij3 = new double[] { matalt1wc1[2], matalt1wc2[2], matalt1wc3[2], matalt1wc4[2], matalt1wc5[2],
                                      matalt2wc1[2], matalt2wc2[2], matalt2wc3[2],matalt2wc4[2],matalt2wc5[2],
                                      matalt3wc1[2],matalt3wc2[2],matalt3wc3[2],matalt3wc4[2],matalt3wc5[2] ,
                                      matalt4wc1[2],matalt4wc2[2],matalt4wc3[2],matalt4wc4[2],matalt4wc5[2],
                                      matalt5wc1[2], matalt5wc2[2], matalt5wc3[2], matalt5wc4[2], matalt5wc5[2]
         };

         zjmax = zij3.Max();

        //zjmin

         double[] zij1 = new double[] { matalt1wc1[0], matalt1wc2[0], matalt1wc3[0], matalt1wc4[0], matalt1wc5[0],
                                      matalt2wc1[0], matalt2wc2[0], matalt2wc3[0],matalt2wc4[0],matalt2wc5[0],
                                      matalt3wc1[0],matalt3wc2[0],matalt3wc3[0],matalt3wc4[0],matalt3wc5[0] ,
                                      matalt4wc1[0],matalt4wc2[0],matalt4wc3[0],matalt4wc4[0],matalt4wc5[0],
                                      matalt5wc1[0], matalt5wc2[0], matalt5wc3[0], matalt5wc4[0], matalt5wc5[0]
         };

         zjmin = zij3.Min();

        // Step 7 Calculate distance measure to A+ and A-

        double rplus , rminus ;

        
        // ideal coordinates
        double[] zpcord = new double[]{zjmax,zjmax,zjmax};
        //
         double[] zmcord = new double[]{zjmin,zjmin,zjmin};
        //
        double[] zj = new double[] { matalt1wc1[0], matalt1wc2[0], matalt1wc3[0], matalt1wc4[0], matalt1wc5[0],
                                      matalt2wc1[0], matalt2wc2[0], matalt2wc3[0],matalt2wc4[0],matalt2wc5[0],
                                      matalt3wc1[0],matalt3wc2[0],matalt3wc3[0],matalt3wc4[0],matalt3wc5[0] ,
                                      matalt4wc1[0],matalt4wc2[0],matalt4wc3[0],matalt4wc4[0],matalt4wc5[0],
                                      matalt5wc1[0], matalt5wc2[0], matalt5wc3[0], matalt5wc4[0], matalt5wc5[0] };

         int num = zj.Length;

        //       
             //compute positive distance d(zij,zj+)

        //alt1

         double dalt1wc1 = Math.Sqrt((Math.Pow((matalt1wc1[0] - zjmax),2) +Math.Pow( (matalt1wc1[1] - zjmax),2) +Math.Pow( (matalt1wc1[2]-zjmax),2))/3);
         double dalt1wc2 = Math.Sqrt((Math.Pow((matalt1wc2[0] - zjmax), 2) + Math.Pow((matalt1wc2[1] - zjmax), 2) + Math.Pow((matalt1wc2[2] - zjmax), 2)) / 3);
         double dalt1wc3 = Math.Sqrt((Math.Pow((matalt1wc3[0] - zjmax), 2) + Math.Pow((matalt1wc3[1] - zjmax), 2) + Math.Pow((matalt1wc3[2] - zjmax), 2)) / 3);
         double dalt1wc4 = Math.Sqrt((Math.Pow((matalt1wc4[0] - zjmax), 2) + Math.Pow((matalt1wc4[1] - zjmax), 2) + Math.Pow((matalt1wc4[2] - zjmax), 2)) / 3);
         double dalt1wc5 = Math.Sqrt((Math.Pow((matalt1wc5[0] - zjmax), 2) + Math.Pow((matalt1wc5[1] - zjmax), 2) + Math.Pow((matalt1wc5[2] - zjmax), 2)) / 3);

        //alt2

         double dalt2wc1 = Math.Sqrt((Math.Pow((matalt2wc1[0] - zjmax), 2) + Math.Pow((matalt2wc1[1] - zjmax), 2) + Math.Pow((matalt2wc1[2] - zjmax), 2)) / 3);
         double dalt2wc2 = Math.Sqrt((Math.Pow((matalt2wc2[0] - zjmax), 2) + Math.Pow((matalt2wc2[1] - zjmax), 2) + Math.Pow((matalt2wc2[2] - zjmax), 2)) / 3);
         double dalt2wc3 = Math.Sqrt((Math.Pow((matalt2wc3[0] - zjmax), 2) + Math.Pow((matalt2wc3[1] - zjmax), 2) + Math.Pow((matalt2wc3[2] - zjmax), 2)) / 3);
         double dalt2wc4 = Math.Sqrt((Math.Pow((matalt2wc4[0] - zjmax), 2) + Math.Pow((matalt2wc4[1] - zjmax), 2) + Math.Pow((matalt2wc4[2] - zjmax), 2)) / 3);
         double dalt2wc5 = Math.Sqrt((Math.Pow((matalt2wc5[0] - zjmax), 2) + Math.Pow((matalt2wc5[1] - zjmax), 2) + Math.Pow((matalt2wc5[2] - zjmax), 2)) / 3);

        //alt3

         double dalt3wc1 = Math.Sqrt((Math.Pow((matalt3wc1[0] - zjmax), 2) + Math.Pow((matalt3wc1[1] - zjmax), 2) + Math.Pow((matalt3wc1[2] - zjmax), 2)) / 3);
         double dalt3wc2 = Math.Sqrt((Math.Pow((matalt3wc2[0] - zjmax), 2) + Math.Pow((matalt3wc2[1] - zjmax), 2) + Math.Pow((matalt3wc2[2] - zjmax), 2)) / 3);
         double dalt3wc3 = Math.Sqrt((Math.Pow((matalt3wc3[0] - zjmax), 2) + Math.Pow((matalt3wc3[1] - zjmax), 2) + Math.Pow((matalt3wc3[2] - zjmax), 2)) / 3);
         double dalt3wc4 = Math.Sqrt((Math.Pow((matalt3wc4[0] - zjmax), 2) + Math.Pow((matalt3wc4[1] - zjmax), 2) + Math.Pow((matalt3wc4[2] - zjmax), 2)) / 3);
         double dalt3wc5 = Math.Sqrt((Math.Pow((matalt3wc5[0] - zjmax), 2) + Math.Pow((matalt3wc5[1] - zjmax), 2) + Math.Pow((matalt3wc5[2] - zjmax), 2)) / 3);

        //alt4

         double dalt4wc1 = Math.Sqrt((Math.Pow((matalt4wc1[0] - zjmax), 2) + Math.Pow((matalt4wc1[1] - zjmax), 2) + Math.Pow((matalt4wc1[2] - zjmax), 2)) / 3);
         double dalt4wc2 = Math.Sqrt((Math.Pow((matalt4wc2[0] - zjmax), 2) + Math.Pow((matalt4wc2[1] - zjmax), 2) + Math.Pow((matalt4wc2[2] - zjmax), 2)) / 3);
         double dalt4wc3 = Math.Sqrt((Math.Pow((matalt4wc3[0] - zjmax), 2) + Math.Pow((matalt4wc3[1] - zjmax), 2) + Math.Pow((matalt4wc3[2] - zjmax), 2)) / 3);
         double dalt4wc4 = Math.Sqrt((Math.Pow((matalt4wc4[0] - zjmax), 2) + Math.Pow((matalt4wc4[1] - zjmax), 2) + Math.Pow((matalt4wc4[2] - zjmax), 2)) / 3);
         double dalt4wc5 = Math.Sqrt((Math.Pow((matalt4wc5[0] - zjmax), 2) + Math.Pow((matalt4wc5[1] - zjmax), 2) + Math.Pow((matalt4wc5[2] - zjmax), 2)) / 3);

        //alt5

         double dalt5wc1 = Math.Sqrt((Math.Pow((matalt5wc1[0] - zjmax), 2) + Math.Pow((matalt5wc1[1] - zjmax), 2) + Math.Pow((matalt5wc1[2] - zjmax), 2)) / 3);
         double dalt5wc2 = Math.Sqrt((Math.Pow((matalt5wc2[0] - zjmax), 2) + Math.Pow((matalt5wc2[1] - zjmax), 2) + Math.Pow((matalt5wc2[2] - zjmax), 2)) / 3);
         double dalt5wc3 = Math.Sqrt((Math.Pow((matalt5wc3[0] - zjmax), 2) + Math.Pow((matalt5wc3[1] - zjmax), 2) + Math.Pow((matalt5wc3[2] - zjmax), 2)) / 3);
         double dalt5wc4 = Math.Sqrt((Math.Pow((matalt5wc4[0] - zjmax), 2) + Math.Pow((matalt5wc4[1] - zjmax), 2) + Math.Pow((matalt5wc4[2] - zjmax), 2)) / 3);
         double dalt5wc5 = Math.Sqrt((Math.Pow((matalt5wc5[0] - zjmax), 2) + Math.Pow((matalt5wc5[1] - zjmax), 2) + Math.Pow((matalt5wc5[2] - zjmax), 2)) / 3);





             //compute negative distance d(zij,zj-)

         //alt1

         double ddalt1wc1 = Math.Sqrt((Math.Pow((matalt1wc1[0] - zjmin), 2) + Math.Pow((matalt1wc1[1] - zjmin), 2) + Math.Pow((matalt1wc1[2] - zjmin), 2)) / 3);
         double  ddalt1wc2 = Math.Sqrt((Math.Pow((matalt1wc2[0] - zjmin), 2) + Math.Pow((matalt1wc2[1] - zjmin), 2) + Math.Pow((matalt1wc2[2] - zjmin), 2)) / 3);
         double  ddalt1wc3 = Math.Sqrt((Math.Pow((matalt1wc3[0] - zjmin), 2) + Math.Pow((matalt1wc3[1] - zjmin), 2) + Math.Pow((matalt1wc3[2] - zjmin), 2)) / 3);
         double  ddalt1wc4 = Math.Sqrt((Math.Pow((matalt1wc4[0] - zjmin), 2) + Math.Pow((matalt1wc4[1] - zjmin), 2) + Math.Pow((matalt1wc4[2] - zjmin), 2)) / 3);
         double  ddalt1wc5 = Math.Sqrt((Math.Pow((matalt1wc5[0] - zjmin), 2) + Math.Pow((matalt1wc5[1] - zjmin), 2) + Math.Pow((matalt1wc5[2] - zjmin), 2)) / 3);

         //alt2

         double ddalt2wc1 = Math.Sqrt((Math.Pow((matalt2wc1[0] - zjmin), 2) + Math.Pow((matalt2wc1[1] - zjmin), 2) + Math.Pow((matalt2wc1[2] - zjmin), 2)) / 3);
         double ddalt2wc2 = Math.Sqrt((Math.Pow((matalt2wc2[0] - zjmin), 2) + Math.Pow((matalt2wc2[1] - zjmin), 2) + Math.Pow((matalt2wc2[2] - zjmin), 2)) / 3);
         double ddalt2wc3 = Math.Sqrt((Math.Pow((matalt2wc3[0] - zjmin), 2) + Math.Pow((matalt2wc3[1] - zjmin), 2) + Math.Pow((matalt2wc3[2] - zjmin), 2)) / 3);
         double ddalt2wc4 = Math.Sqrt((Math.Pow((matalt2wc4[0] - zjmin), 2) + Math.Pow((matalt2wc4[1] - zjmin), 2) + Math.Pow((matalt2wc4[2] - zjmin), 2)) / 3);
         double ddalt2wc5 = Math.Sqrt((Math.Pow((matalt2wc5[0] - zjmin), 2) + Math.Pow((matalt2wc5[1] - zjmin), 2) + Math.Pow((matalt2wc5[2] - zjmin), 2)) / 3);

         //alt3

         double ddalt3wc1 = Math.Sqrt((Math.Pow((matalt3wc1[0] - zjmin), 2) + Math.Pow((matalt3wc1[1] - zjmin), 2) + Math.Pow((matalt3wc1[2] - zjmin), 2)) / 3);
         double ddalt3wc2 = Math.Sqrt((Math.Pow((matalt3wc2[0] - zjmin), 2) + Math.Pow((matalt3wc2[1] - zjmin), 2) + Math.Pow((matalt3wc2[2] - zjmin), 2)) / 3);
         double ddalt3wc3 = Math.Sqrt((Math.Pow((matalt3wc3[0] - zjmin), 2) + Math.Pow((matalt3wc3[1] - zjmin), 2) + Math.Pow((matalt3wc3[2] - zjmin), 2)) / 3);
         double ddalt3wc4 = Math.Sqrt((Math.Pow((matalt3wc4[0] - zjmin), 2) + Math.Pow((matalt3wc4[1] - zjmin), 2) + Math.Pow((matalt3wc4[2] - zjmin), 2)) / 3);
         double ddalt3wc5 = Math.Sqrt((Math.Pow((matalt3wc5[0] - zjmin), 2) + Math.Pow((matalt3wc5[1] - zjmin), 2) + Math.Pow((matalt3wc5[2] - zjmin), 2)) / 3);

         //alt4

         double ddalt4wc1 = Math.Sqrt((Math.Pow((matalt4wc1[0] - zjmin), 2) + Math.Pow((matalt4wc1[1] - zjmin), 2) + Math.Pow((matalt4wc1[2] - zjmin), 2)) / 3);
         double ddalt4wc2 = Math.Sqrt((Math.Pow((matalt4wc2[0] - zjmin), 2) + Math.Pow((matalt4wc2[1] - zjmin), 2) + Math.Pow((matalt4wc2[2] - zjmin), 2)) / 3);
         double ddalt4wc3 = Math.Sqrt((Math.Pow((matalt4wc3[0] - zjmin), 2) + Math.Pow((matalt4wc3[1] - zjmin), 2) + Math.Pow((matalt4wc3[2] - zjmin), 2)) / 3);
         double ddalt4wc4 = Math.Sqrt((Math.Pow((matalt4wc4[0] - zjmin), 2) + Math.Pow((matalt4wc4[1] - zjmin), 2) + Math.Pow((matalt4wc4[2] - zjmin), 2)) / 3);
         double ddalt4wc5 = Math.Sqrt((Math.Pow((matalt4wc5[0] - zjmin), 2) + Math.Pow((matalt4wc5[1] - zjmin), 2) + Math.Pow((matalt4wc5[2] - zjmin), 2)) / 3);

         //alt5

         double ddalt5wc1 = Math.Sqrt((Math.Pow((matalt5wc1[0] - zjmin), 2) + Math.Pow((matalt5wc1[1] - zjmin), 2) + Math.Pow((matalt5wc1[2] - zjmin), 2)) / 3);
         double ddalt5wc2 = Math.Sqrt((Math.Pow((matalt5wc2[0] - zjmin), 2) + Math.Pow((matalt5wc2[1] - zjmin), 2) + Math.Pow((matalt5wc2[2] - zjmin), 2)) / 3);
         double ddalt5wc3 = Math.Sqrt((Math.Pow((matalt5wc3[0] - zjmin), 2) + Math.Pow((matalt5wc3[1] - zjmin), 2) + Math.Pow((matalt5wc3[2] - zjmin), 2)) / 3);
         double ddalt5wc4 = Math.Sqrt((Math.Pow((matalt5wc4[0] - zjmin), 2) + Math.Pow((matalt5wc4[1] - zjmin), 2) + Math.Pow((matalt5wc4[2] - zjmin), 2)) / 3);
         double ddalt5wc5 = Math.Sqrt((Math.Pow((matalt5wc5[0] - zjmin), 2) + Math.Pow((matalt5wc5[1] - zjmin), 2) + Math.Pow((matalt5wc5[2] - zjmin), 2)) / 3);

        // definitions
        double siplus1,siminus1,riplus1,riminus1;
        double [] siplus1arr,siminus1arr,riplus1arr,riminus1arr;
        //
        double siplus2, siminus2, riplus2, riminus2;
        double [] siplus2arr,siminus2arr,riplus2arr,riminus2arr;
        //
        double siplus3, siminus3, riplus3, riminus3;
        double [] siplus3arr,siminus3arr,riplus3arr,riminus3arr;
        //
        double siplus4, siminus4, riplus4, riminus4;
        double [] siplus4arr,siminus4arr,riplus4arr,riminus4arr;
        //
        double siplus5, siminus5, riplus5, riminus5;
        double [] siplus5arr,siminus5arr,riplus5arr,riminus5arr;
        
        // Alternative 1 values for siplus , siminus,riplus,riminus 
        //
        siplus1 = dalt1wc1 + dalt1wc2 + dalt1wc3 + dalt1wc4 + dalt1wc5 ;
        siminus1 = ddalt1wc1 + ddalt1wc2 + ddalt1wc3 + ddalt1wc4 + ddalt1wc5 ;
        siplus1arr = new double[]{dalt1wc1 , dalt1wc2 , dalt1wc3 , dalt1wc4 ,dalt1wc5};
        siminus1arr = new double[]{ddalt1wc1 ,ddalt1wc2 , ddalt1wc3 , ddalt1wc4 ,ddalt1wc5 };
        riplus1 = siplus1arr.Max();
        riminus1 = siminus1arr.Max();
         
        
        // Alternative 2 values for siplus , siminus,riplus,riminus 

        siplus2 = dalt2wc1 + dalt2wc2 + dalt2wc3 + dalt2wc4 + dalt2wc5 ;
        siminus2 = ddalt2wc1 + ddalt2wc2 + ddalt2wc3 + ddalt2wc4 + ddalt2wc5;
        siplus2arr = new double[]{dalt2wc1 , dalt2wc2 , dalt2wc3 , dalt2wc4 , dalt2wc5};
        siminus2arr = new double[]{ddalt2wc1 , ddalt2wc2 , ddalt2wc3 ,ddalt2wc4 ,ddalt2wc5};
        riplus2 = siplus2arr.Max();
        riminus2 = siminus2arr.Max();

        // Alternative 3 values for siplus , siminus,riplus,riminus 

       siplus3 = dalt3wc1 + dalt3wc2 + dalt3wc3 + dalt3wc4 + dalt3wc5;
       siminus3 =   ddalt3wc1 + ddalt3wc2 + ddalt3wc3 + ddalt3wc4 + ddalt3wc5;
       siplus3arr = new double []{dalt3wc1 ,dalt3wc2 , dalt3wc3 ,dalt3wc4 , dalt3wc5};
       siminus3arr = new double[]{ddalt3wc1 ,ddalt3wc2 , ddalt3wc3 ,ddalt3wc4 , ddalt3wc5};
       riplus3 = siplus3arr.Max();
       riminus3 = siminus3arr.Max();
                                         
        // Alternative 4 values for siplus , siminus,riplus,riminus 

        siplus4 =  dalt4wc1 + dalt4wc2 + dalt4wc3 + dalt4wc4 + dalt4wc5 ;
        siminus4 = ddalt4wc1 + ddalt4wc2 + ddalt4wc3 + ddalt4wc4 + ddalt4wc5 ;
        siplus4arr = new double[]{dalt4wc1 , dalt4wc2 , dalt4wc3 , dalt4wc4 , dalt4wc5 };
        siminus4arr = new double []{ddalt4wc1 , ddalt4wc2 , ddalt4wc3 , ddalt4wc4 , ddalt4wc5};
         riplus4 = siplus4arr.Max();
       riminus4 = siminus4arr.Max();

        //  Alternative 5 values for siplus , siminus,riplus,riminus 

        siplus5 = dalt5wc1 + dalt5wc2 + dalt5wc3 + dalt5wc4 + dalt5wc5;
        siminus5 = ddalt5wc1 + ddalt5wc2 + ddalt5wc3 + ddalt5wc4 + ddalt5wc5;
        siplus5arr = new double[]{dalt5wc1 , dalt5wc2 , dalt5wc3 , dalt5wc4 , dalt5wc5};
        siminus5arr = new double[]{ddalt5wc1 , ddalt5wc2 , ddalt5wc3 , ddalt5wc4 , ddalt5wc5};
        riplus5 = siplus5arr.Max();
        riminus5 = siminus5arr.Max();
       
     
// collections for all siplus,siminus,riplus,riminus for all alternative to calculate qiplus and qiminus

        double[] sipluscoll, siminuscoll, ripluscoll, riminuscoll;
        double v = 0.5;
// collections
        sipluscoll = new double[] { siplus1, siplus2, siplus3, siplus4, siplus5 };
        siminuscoll = new double[] { siminus1, siminus2, siminus3, siminus4, siminus5 };
        ripluscoll = new double[] { riplus1, riplus2, riplus3, riplus4, riplus5 };
        riminuscoll = new double[] { riminus1, riminus2, riminus3, riminus4, riminus5 };

// max and mins

        double minsiplus, maxsiplus, minsiminus, maxsiminus, minriplus, maxriplus, minriminus, maxriminus;

        minsiplus = sipluscoll.Min();
        maxsiplus = sipluscoll.Max();
        minsiminus = siminuscoll.Min();
        maxsiminus = siminuscoll.Max();
        minriplus = ripluscoll.Min();
        maxriplus = ripluscoll.Max();
        minriminus = riminuscoll.Min();
        maxriminus = riminuscoll.Max();


        // calculate qiplus and qiminus for each alternative

// Alternative 1

        double qiplus1 = v * ((siplus1 - minsiplus) / (maxsiplus - minsiplus)) + (1 - v) * ((riplus1 - minriplus) / (maxriplus - minriplus));

        double qiminus1 = v * ((siminus1 - minsiminus) / (maxsiminus - minsiminus)) + (1 - v) * ((riminus1 - minriminus) / (maxriminus - minriminus));

// Alternative 2

        double qiplus2 = v * ((siplus2 - minsiplus) / (maxsiplus - minsiplus)) + (1 - v) * ((riplus2 - minriplus) / (maxriplus - minriplus));

        double qiminus2 = v * ((siminus2 - minsiminus) / (maxsiminus - minsiminus)) + (1 - v) * ((riminus2 - minriminus) / (maxriminus - minriminus));

// Alternative 3

        double qiplus3 = v * ((siplus3 - minsiplus) / (maxsiplus - minsiplus)) + (1 - v) * ((riplus3 - minriplus) / (maxriplus - minriplus));

        double qiminus3 = v * ((siminus3 - minsiminus) / (maxsiminus - minsiminus)) + (1 - v) * ((riminus3 - minriminus) / (maxriminus - minriminus));

// Alternative 4

        double qiplus4 = v * ((siplus4 - minsiplus) / (maxsiplus - minsiplus)) + (1 - v) * ((riplus4 - minriplus) / (maxriplus - minriplus));

        double qiminus4 = v * ((siminus4 - minsiminus) / (maxsiminus - minsiminus)) + (1 - v) * ((riminus4 - minriminus) / (maxriminus - minriminus));

// Alternative 5

        double qiplus5 = v * ((siplus5 - minsiplus) / (maxsiplus - minsiplus)) + (1 - v) * ((riplus5 - minriplus) / (maxriplus - minriplus));

        double qiminus5 = v * ((siminus5 - minsiminus) / (maxsiminus - minsiminus)) + (1 - v) * ((riminus5 - minriminus) / (maxriminus - minriminus));




    }
   
}
