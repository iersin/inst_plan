using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Data;

namespace InstallmentPlan
{
    [DataContract]
    public sealed class CollectionPlan
    {
        #region Field Members
        short _instalmentMethod;
        short _instalmentCount;
        short _instalmentPeriod;
        short _exInstalmentType;
        decimal _exInstalmentValue;
        short _exInstalmentPeriod;
        DateTime _projectStartDate;
        DateTime _projectEndDate;
        DateTime _firstInstalmentDate;
        decimal _profitRate;
        decimal _kdvRate;
        decimal _bsmvRate;
        decimal _kkdfRate;
        decimal _cost;
        decimal _amount;
        decimal _profit;
        decimal _kdv;
        decimal _kkdf;
        decimal _profitKdv;
        decimal _bsmv;
        decimal _avgdue;
        decimal _realProfitRate;
        Dictionary<int, double> _incomeGrowthRate;

        CollectionPlanInstalment[] _collectionPlanInstalmentArray;
        double[] _coefList;
        decimal[] _costList;
        #endregion

        #region Property Members

        /// <summary>
        /// kredi ödeme türü
        /// </summary>
        [DataMember]
        public short InstalmentMethod
        {
            get { return _instalmentMethod; }
            set { _instalmentMethod = value; }
        }
        /// <summary>
        /// kredi taksit sayısı
        /// </summary>
        [DataMember]
        public short InstalmentCount
        {
            get { return _instalmentCount; }
            set { _instalmentCount = value; }
        }
        /// <summary>
        /// kredi ödeme periyodu
        /// </summary>
        [DataMember]
        public short InstalmentPeriod
        {
            get { return _instalmentPeriod; }
            set { _instalmentPeriod = value; }
        }
        /// <summary>
        /// ek ödeme tipi (adet, tutar)
        /// </summary>
        [DataMember]
        public short ExInstalmentType
        {
            get { return _exInstalmentType; }
            set { _exInstalmentType = value; }
        }
        /// <summary>
        /// ek ödeme periyodu
        /// </summary>
        [DataMember]
        public short ExInstalmentPeriod
        {
            get { return _exInstalmentPeriod; }
            set { _exInstalmentPeriod = value; }
        }
        /// <summary>
        /// ek Ödeme Değeri
        /// </summary>
        [DataMember]
        public decimal ExInstalmentValue
        {
            get { return _exInstalmentValue; }
            set { _exInstalmentValue = value; }
        }
        /// <summary>
        /// başlangıç tarihi
        /// </summary>
        [DataMember]
        public DateTime ProjectStartDate
        {
            get { return _projectStartDate; }
            set { _projectStartDate = value; }
        }
        /// <summary>
        /// bitiş tarihi
        /// </summary>
        [DataMember]
        public DateTime ProjectEndDate
        {
            get { return _projectEndDate; }
            set { _projectEndDate = value; }
        }
        /// <summary>
        /// ilk taksit tarihi
        /// </summary>
        [DataMember]
        public DateTime FirstInstalmentDate
        {
            get { return _firstInstalmentDate; }
            set { _firstInstalmentDate = value; }
        }
        /// <summary>
        /// kar oranı
        /// </summary>
        [DataMember]
        public decimal ProfitRate
        {
            get { return _profitRate; }
            set { _profitRate = value; }
        }
        /// <summary>
        /// kdv oranı
        /// </summary>
        [DataMember]
        public decimal KdvRate
        {
            get { return _kdvRate; }
            set { _kdvRate = value; }
        }
        /// <summary>
        /// bsmv oranı
        /// </summary>
        [DataMember]
        public decimal BsmvRate
        {
            get { return _bsmvRate; }
            set { _bsmvRate = value; }
        }
        /// <summary>
        /// kkdf oranı
        /// </summary>
        [DataMember]
        public decimal KkdfRate
        {
            get { return _kkdfRate; }
            set { _kkdfRate = value; }
        }
        /// <summary>
        /// kredi anapara tutarı
        /// </summary>
        [DataMember]
        public decimal Cost
        {
            get { return _cost; }
            set { _cost = value; }
        }
        /// <summary>
        /// kredi toplam tutar
        /// </summary>
        [DataMember]
        public decimal Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }
        /// <summary>
        /// kredi kar tutarı
        /// </summary>
        [DataMember]
        public decimal Profit
        {
            get { return _profit; }
            set { _profit = value; }
        }
        /// <summary>
        /// kredi gerçek kar tutarı
        /// </summary>
        [DataMember]
        public decimal RealProfitRate
        {
            get { return _realProfitRate; }
            set { _realProfitRate = value; }
        }
        /// <summary>
        /// kredi ortalama vade
        /// </summary>
        [DataMember]
        public decimal AvgDue
        {
            get { return _avgdue; }
            set { _avgdue = value; }
        }
        /// <summary>
        /// kredi kdv tutarı
        /// </summary>
        [DataMember]
        public decimal Kdv
        {
            get { return _kdv; }
            set { _kdv = value; }
        }
        /// <summary>
        /// kredi kkdf tutarı
        /// </summary>
        [DataMember]
        public decimal Kkdf
        {
            get { return _kkdf; }
            set { _kkdf = value; }
        }
        /// <summary>
        /// kredi karının kdv tutarı
        /// </summary>
        [DataMember]
        public decimal ProfitKdv
        {
            get { return _profitKdv; }
            set { _profitKdv = value; }
        }
        /// <summary>
        /// kredi bsmv tutarı
        /// </summary>
        [DataMember]
        public decimal Bsmv
        {
            get { return _bsmv; }
            set { _bsmv = value; }
        }

        /// <summary>
        /// Hesaplanan tahsilat planı
        /// </summary>
        [DataMember]
        public CollectionPlanInstalment[] CollectionPlanInstalmentArray
        {
            get { return _collectionPlanInstalmentArray; }
            set { _collectionPlanInstalmentArray = value; }
        }

        /// <summary>
        /// coef listesi
        /// </summary>
        [DataMember]
        public double[] CoefList
        {
            get { return _coefList; }
            set { _coefList = value; }
        }

        /// <summary>
        /// coestList
        /// </summary>
        [DataMember]
        public decimal[] CostList
        {
            get { return _costList; }
            set { _costList = value; }
        }

        /// <summary>
        /// Ödeme Planı gelir değişim bilgileri
        /// </summary>
        [DataMember]
        public Dictionary<int, double> IncomeGrowthRate
        {
            get { return _incomeGrowthRate; }
            set { _incomeGrowthRate = value; }
        }
        #endregion

        #region hesaplamalar
        /// <summary>
        /// taksit tarihlerini set eder
        /// </summary>
        public static CollectionPlan SetCollectionPlanSchedule(CollectionPlan collectionPlan)
        {
            //if (collectionPlan == null)
            //    throw new ErrorException();
            collectionPlan.CollectionPlanInstalmentArray = new CollectionPlanInstalment[collectionPlan.InstalmentCount];

            DateTime prevDate, inDate;
            prevDate = collectionPlan.ProjectStartDate;
            inDate = collectionPlan.FirstInstalmentDate;
            // ilk taksit için işlemler
            for (int i = 0; i < 1; i++)
            {
                collectionPlan.CollectionPlanInstalmentArray[i] = new CollectionPlanInstalment();
                collectionPlan.CollectionPlanInstalmentArray[i].InstalmentDate = inDate;
                collectionPlan.CollectionPlanInstalmentArray[i].ValueDate = inDate;
                TimeSpan dayDiff = inDate - prevDate;
                TimeSpan dayCount = inDate - collectionPlan.ProjectStartDate;
                collectionPlan.CollectionPlanInstalmentArray[i].DayCount = (short)dayCount.Days;
                collectionPlan.CollectionPlanInstalmentArray[i].DayDiff = (short)dayDiff.Days;
                collectionPlan.CollectionPlanInstalmentArray[i].MonthCount = 0;
                collectionPlan.CollectionPlanInstalmentArray[i].MonthDiff = 0;
                prevDate = inDate;
            }
            // diğer taksitler için işlemler
            for (int i = 1; i < collectionPlan.InstalmentCount; i++)
            {
                collectionPlan.CollectionPlanInstalmentArray[i] = new CollectionPlanInstalment();
                if (collectionPlan.InstalmentMethod == 3)//(short)InstalmentMethod.AdditionalPayment)
                {
                    inDate = collectionPlan.FirstInstalmentDate.AddMonths(i);
                    collectionPlan.CollectionPlanInstalmentArray[i].MonthDiff = 1;
                    collectionPlan.CollectionPlanInstalmentArray[i].MonthCount = (short)i;
                }
                else
                {
                    inDate = collectionPlan.FirstInstalmentDate.AddMonths(i * collectionPlan.InstalmentPeriod);
                    if (inDate.Month == prevDate.Month)
                    {
                        while (true)
                        {
                            inDate = inDate.AddDays(1);
                            if (inDate.Month != prevDate.Month)
                                break;
                        }

                    }
                    //inDate = CalendarInterface.GetNearestWorkDate(collectionPlan.FirstInstalmentDate.AddMonths(collectionPlan.InstalmentPeriod * i));
                    collectionPlan.CollectionPlanInstalmentArray[i].MonthDiff = collectionPlan.InstalmentPeriod;
                    collectionPlan.CollectionPlanInstalmentArray[i].MonthCount = (short)(i * collectionPlan.InstalmentPeriod);
                }
                collectionPlan.CollectionPlanInstalmentArray[i].InstalmentDate = inDate;
                collectionPlan.CollectionPlanInstalmentArray[i].ValueDate = inDate;
                TimeSpan dayDiff = inDate - prevDate;
                TimeSpan dayCount = inDate - collectionPlan.ProjectStartDate;
                collectionPlan.CollectionPlanInstalmentArray[i].DayCount = (short)dayCount.Days;
                collectionPlan.CollectionPlanInstalmentArray[i].DayDiff = (short)dayDiff.Days;
                prevDate = inDate;
            }

            return collectionPlan;
        }

        /// <summary>
        /// taksit bilgilerini set eder
        /// </summary>
        public static CollectionPlan CreateCollectionPlan(CollectionPlan collectionPlan)
        {
            double dTax = (1 + (double)(collectionPlan.KkdfRate + collectionPlan.BsmvRate + collectionPlan.KdvRate) / 100);
            double dPR = (1 + (double)collectionPlan.ProfitRate / 100);
            double dIRM = (1 + dTax * (double)collectionPlan.ProfitRate / 100);
            double dx = 0, dc = 0;
            double r1st = 0; // ???
            //collectionPlan.FirstInstalmentDate = collectionPlan.FirstInstalmentDate;

            //ie006294 ilk taksit tarihi defaultta 1 ay sonrasına set ediliyor. Bir şekilde taksit tarihi değiştirilmediyse ama 1 ay sonrası iş günü değilse ve öteleniyorsa 
            //bu durumda da 30 günlük kar işletmek gerekiyor. (teftiş bulgusu sebebiyle değişiklik yapıldı. aynı değişiklikler vb tarafında da yapıldı.)
            //bool isFirstInstallmentDateChanged = false;
            DateTime projectStartDate = DateTime.Now.Date; // Bu metodun kullanıldığı yerlerde proje başlangıç tarihi değiştirilemediğinden dolayı bu şekilde kullanılmıştır.
            //projectStartDate = new DateTime(2018, 1, 24);
            DateTime firstInstallmentDate = projectStartDate.AddMonths(1);
            int dayDiff = 0;
            int gunFarki;
            decimal karFarki = 0;
            decimal kkdfFarki = 0;
            decimal bsmvFarki = 0;
            if (firstInstallmentDate == collectionPlan.FirstInstalmentDate && projectStartDate == collectionPlan.ProjectStartDate)
            {
                //isFirstInstallmentDateChanged = false;
                dayDiff = 30;
            }
            else
            {
                //isFirstInstallmentDateChanged = true;
                dayDiff = collectionPlan.CollectionPlanInstalmentArray[0].DayDiff;
                gunFarki = (collectionPlan.FirstInstalmentDate - collectionPlan.ProjectStartDate).Days - 30;
                karFarki = Math.Round(collectionPlan.Cost * (collectionPlan.ProfitRate / 100) * gunFarki / 30, 2, MidpointRounding.AwayFromZero);
                kkdfFarki = Math.Round(karFarki * collectionPlan.KkdfRate / 100, 2 , MidpointRounding.AwayFromZero);
                bsmvFarki = Math.Round(karFarki * collectionPlan.BsmvRate / 100, 2, MidpointRounding.AwayFromZero);
            }

            if (collectionPlan.InstalmentMethod == (short)InstallmentPlan.InstalmentMethod.VariablePrincipal)
            {
                for (int i = 0; i < collectionPlan.InstalmentCount; i++)
                {
                    collectionPlan.CollectionPlanInstalmentArray[i].Cost = collectionPlan.CostList[i];
                }
            }


            for (int i = 0; i < collectionPlan.InstalmentCount; i++)
            {
                if (i == 0)
                {
                    r1st = 1;// (double)dayDiff/ 30;
                    //collectionPlan.CollectionPlanInstalmentArray[i].IRD = (decimal)(Math.Pow(dPR, (double)1 / 30) - 1);
                    //collectionPlan.CollectionPlanInstalmentArray[i].IRD = (decimal)(Math.Pow(dIRM, (double)1 / (isFirstInstallmentDateChanged ? 30 : collectionPlan.CollectionPlanInstalmentArray[i].DayDiff)) - 1);
                    //collectionPlan.CollectionPlanInstalmentArray[i].IRD = (decimal)(Math.Pow(dIRM, (double)1 / 30) - 1);
                    double x = (double)dayDiff / 30;
                    collectionPlan.CollectionPlanInstalmentArray[i].IRD = (decimal)(Math.Pow(dIRM, (double)x / collectionPlan.CollectionPlanInstalmentArray[i].DayDiff) - 1);

                }
                else
                {
                    //collectionPlan.CollectionPlanInstalmentArray[i].IRD = (decimal)Math.Pow(dPR, (double)collectionPlan.CollectionPlanInstalmentArray[i].MonthDiff / collectionPlan.CollectionPlanInstalmentArray[i].DayDiff) - 1;
                    collectionPlan.CollectionPlanInstalmentArray[i].IRD = (decimal)Math.Pow(dIRM, (double)collectionPlan.CollectionPlanInstalmentArray[i].MonthDiff / collectionPlan.CollectionPlanInstalmentArray[i].DayDiff) - 1;
                }
                dx += collectionPlan.CoefList[i] / Math.Pow(dIRM, collectionPlan.CollectionPlanInstalmentArray[i].MonthCount);
                dc += collectionPlan.CoefList[i];
            }
            dx /= Math.Pow(dIRM, r1st);
            double dExCost = 0;
            if (collectionPlan.InstalmentMethod == 3//(short)InstalmentMethod.AdditionalPayment
                && collectionPlan.ExInstalmentType == 2) //(short)ExInstalmentType.Amount) // ExInstalmentType işin içinde
            {
                for (int i = collectionPlan.ExInstalmentPeriod - 1; i < collectionPlan.InstalmentCount; i += collectionPlan.InstalmentPeriod)
                {
                    dExCost += (double)collectionPlan.ExInstalmentValue / Math.Pow(dIRM, r1st + collectionPlan.CollectionPlanInstalmentArray[i].MonthCount);
                }
            }
            double v1 = ((double)collectionPlan.Cost - dExCost) / dx;
            double dCost = (double)collectionPlan.Cost;
            double vx = 0;
            decimal pCumulativeProfit = 0;
            double pKalanKar = 0;
            double dEqCost = Math.Round((double)collectionPlan.Cost / collectionPlan.InstalmentCount, 2, MidpointRounding.AwayFromZero); // eşit anaparalı için kullanılır



            for (int i = 0; i < collectionPlan.InstalmentCount; i++)
            {
                if (collectionPlan.InstalmentMethod == 3//(short)InstalmentMethod.AdditionalPayment
                    && collectionPlan.ExInstalmentType == 3//(short)ExInstalmentType.Amount
                    && ((i + 1) % collectionPlan.InstalmentPeriod == collectionPlan.ExInstalmentPeriod % collectionPlan.InstalmentPeriod)) // ExInstalmentType ve value işin içinde
                {
                    collectionPlan.CollectionPlanInstalmentArray[i].Amount = (decimal)Math.Round(v1 + (double)collectionPlan.ExInstalmentValue, 2, MidpointRounding.AwayFromZero); // v1 + ExInstalmentValue
                }
                else
                {
                    collectionPlan.CollectionPlanInstalmentArray[i].Amount = (decimal)Math.Round(v1 * collectionPlan.CoefList[i], 2, MidpointRounding.AwayFromZero);
                }
                if (i == 0)
                {
                    //collectionPlan.CollectionPlanInstalmentArray[i].Profit = (decimal)(dCost * (Math.Pow(dPR, r1st) - 1));
                    collectionPlan.CollectionPlanInstalmentArray[i].PeriodicProfit = (decimal)((dCost + pKalanKar) * (Math.Pow(dIRM, r1st) - 1)) + karFarki + kkdfFarki + bsmvFarki;
                    collectionPlan.CollectionPlanInstalmentArray[i].Amount += (karFarki + kkdfFarki + bsmvFarki);
                }
                else
                {
                    //collectionPlan.CollectionPlanInstalmentArray[i].Profit = (decimal)(dCost * (Math.Pow(dPR, collectionPlan.CollectionPlanInstalmentArray[i].MonthDiff) - 1));
                    collectionPlan.CollectionPlanInstalmentArray[i].PeriodicProfit = (decimal)((dCost + pKalanKar) * (Math.Pow(dIRM, collectionPlan.CollectionPlanInstalmentArray[i].MonthDiff) - 1));
                }

                collectionPlan.CollectionPlanInstalmentArray[i].GrossCumulativeProfit = collectionPlan.CollectionPlanInstalmentArray[i].PeriodicProfit + (decimal)pKalanKar;
                collectionPlan.CollectionPlanInstalmentArray[i].PeriodicProfit = Math.Round(collectionPlan.CollectionPlanInstalmentArray[i].PeriodicProfit, 2, MidpointRounding.AwayFromZero);

                if (Math.Round(collectionPlan.CollectionPlanInstalmentArray[i].GrossCumulativeProfit, 2, MidpointRounding.AwayFromZero) >= collectionPlan.CollectionPlanInstalmentArray[i].Amount)
                {
                    collectionPlan.CollectionPlanInstalmentArray[i].Cost = 0;
                    if (Helper.RoundEx(collectionPlan.CollectionPlanInstalmentArray[i].GrossCumulativeProfit) > collectionPlan.CollectionPlanInstalmentArray[i].Amount)
                    {
                        collectionPlan.CollectionPlanInstalmentArray[i].Profit = collectionPlan.CollectionPlanInstalmentArray[i].Amount / (decimal)dTax;
                        collectionPlan.CollectionPlanInstalmentArray[i].Profit = Helper.RoundEx(collectionPlan.CollectionPlanInstalmentArray[i].Profit);
                        collectionPlan.CollectionPlanInstalmentArray[i].Kkdf = Helper.RoundEx(collectionPlan.CollectionPlanInstalmentArray[i].Profit * collectionPlan.KkdfRate / 100);
                        collectionPlan.CollectionPlanInstalmentArray[i].Bsmv = Helper.RoundEx(collectionPlan.CollectionPlanInstalmentArray[i].Profit * collectionPlan.BsmvRate / 100);

                    }
                }
                else
                {
                    collectionPlan.CollectionPlanInstalmentArray[i].Profit = collectionPlan.CollectionPlanInstalmentArray[i].GrossCumulativeProfit / (decimal)dTax; // Net Kar Tutarı = Brüt Kar Tutarı / (1 + KKDF Oranı + BSMV Oranı)
                    collectionPlan.CollectionPlanInstalmentArray[i].Profit = Helper.RoundEx(collectionPlan.CollectionPlanInstalmentArray[i].Profit);
                    collectionPlan.CollectionPlanInstalmentArray[i].Kkdf = Helper.RoundEx(collectionPlan.CollectionPlanInstalmentArray[i].Profit * collectionPlan.KkdfRate / 100);
                    collectionPlan.CollectionPlanInstalmentArray[i].Bsmv = Helper.RoundEx(collectionPlan.CollectionPlanInstalmentArray[i].Profit * collectionPlan.BsmvRate / 100);


                    if (collectionPlan.InstalmentMethod != (short)InstallmentPlan.InstalmentMethod.VariablePrincipal)
                    {
                        collectionPlan.CollectionPlanInstalmentArray[i].Cost = collectionPlan.CollectionPlanInstalmentArray[i].Amount
                                                                    - (collectionPlan.CollectionPlanInstalmentArray[i].Profit
                                                                        + collectionPlan.CollectionPlanInstalmentArray[i].Kkdf
                                                                        + collectionPlan.CollectionPlanInstalmentArray[i].Bsmv
                                                                        );
                    }
                }

                collectionPlan.CollectionPlanInstalmentArray[i].GrossCumulativeProfit = Helper.RoundEx(collectionPlan.CollectionPlanInstalmentArray[i].GrossCumulativeProfit);
                pKalanKar = (double)(collectionPlan.CollectionPlanInstalmentArray[i].GrossCumulativeProfit - (collectionPlan.CollectionPlanInstalmentArray[i].Profit
                                                                        + collectionPlan.CollectionPlanInstalmentArray[i].Kkdf
                                                                        + collectionPlan.CollectionPlanInstalmentArray[i].Bsmv
                                                                        ));
                if (Math.Abs(pKalanKar) <= 0.02)
                {
                    pKalanKar = 0;
                }
                collectionPlan.CollectionPlanInstalmentArray[i].RemainderProfit = (decimal)pKalanKar;
                
                collectionPlan.CollectionPlanInstalmentArray[i].IsGrossCalculation = true; // hesaplama türü : brüt

                if (collectionPlan.InstalmentMethod == (short)InstallmentPlan.InstalmentMethod.EqualPrincipal)
                {
                    collectionPlan.CollectionPlanInstalmentArray[i].Cost = (decimal)dEqCost;
                    collectionPlan.CollectionPlanInstalmentArray[i].Amount = collectionPlan.CollectionPlanInstalmentArray[i].Cost
                                                                        + collectionPlan.CollectionPlanInstalmentArray[i].Profit +
                                                                        collectionPlan.CollectionPlanInstalmentArray[i].Kkdf +
                                                                        collectionPlan.CollectionPlanInstalmentArray[i].Bsmv ;
                }
                if (collectionPlan.InstalmentMethod == (short)InstallmentPlan.InstalmentMethod.VariablePrincipal)
                {
                    collectionPlan.CollectionPlanInstalmentArray[i].Amount = collectionPlan.CollectionPlanInstalmentArray[i].Cost
                                                                        + collectionPlan.CollectionPlanInstalmentArray[i].Profit +
                                                                        collectionPlan.CollectionPlanInstalmentArray[i].Kkdf +
                                                                        collectionPlan.CollectionPlanInstalmentArray[i].Bsmv ;
                }
                vx += (double)(collectionPlan.CollectionPlanInstalmentArray[i].Amount * collectionPlan.CollectionPlanInstalmentArray[i].DayCount);
                collectionPlan.CollectionPlanInstalmentArray[i].RemainderCost = (decimal)dCost - collectionPlan.CollectionPlanInstalmentArray[i].Cost;
                collectionPlan.CollectionPlanInstalmentArray[i].CumulativeProfit = pCumulativeProfit;
                pCumulativeProfit += collectionPlan.CollectionPlanInstalmentArray[i].Profit;
                dCost = Helper.RoundEx(dCost - (double)collectionPlan.CollectionPlanInstalmentArray[i].Cost);

                collectionPlan.Amount += collectionPlan.CollectionPlanInstalmentArray[i].Amount;
                collectionPlan.Profit += collectionPlan.CollectionPlanInstalmentArray[i].Profit;
                collectionPlan.Kkdf += collectionPlan.CollectionPlanInstalmentArray[i].Kkdf;
                collectionPlan.Bsmv += collectionPlan.CollectionPlanInstalmentArray[i].Bsmv;
            }

            // son taksitte RemainingCost düzenlemesi
            int lastIndex = collectionPlan.InstalmentCount - 1;
            collectionPlan.CollectionPlanInstalmentArray[lastIndex].Cost = collectionPlan.CollectionPlanInstalmentArray[lastIndex].Cost
                                                                        + collectionPlan.CollectionPlanInstalmentArray[lastIndex].RemainderCost;
            collectionPlan.CollectionPlanInstalmentArray[lastIndex].RemainderCost = 0;
            collectionPlan.Amount -= collectionPlan.CollectionPlanInstalmentArray[lastIndex].Amount;
            collectionPlan.CollectionPlanInstalmentArray[lastIndex].Amount = collectionPlan.CollectionPlanInstalmentArray[lastIndex].Cost
                                                                        + collectionPlan.CollectionPlanInstalmentArray[lastIndex].Profit
                                                                        + collectionPlan.CollectionPlanInstalmentArray[lastIndex].Kkdf
                                                                        + collectionPlan.CollectionPlanInstalmentArray[lastIndex].Bsmv;
            collectionPlan.Amount += collectionPlan.CollectionPlanInstalmentArray[lastIndex].Amount;
            collectionPlan.ProjectEndDate = collectionPlan.CollectionPlanInstalmentArray[lastIndex].InstalmentDate;

            collectionPlan.RealProfitRate = 100 * (collectionPlan.Profit / collectionPlan.Cost);
            if (collectionPlan.Amount != 0) collectionPlan.AvgDue = Helper.RoundEx((decimal)vx / collectionPlan.Amount);

            return collectionPlan;
        }

        /// <summary>
        /// coef listesini set eder
        /// </summary>
        public static CollectionPlan SetCoefList(CollectionPlan collectionPlan)
        {
            if (collectionPlan.CoefList == null)
                collectionPlan.CoefList = new double[collectionPlan.InstalmentCount];

            if (collectionPlan.CostList == null)
            {
                collectionPlan.CostList = new decimal[collectionPlan.InstalmentCount];
                //collectionPlan.CostList.ForEach(1);
            }


            if (collectionPlan.InstalmentMethod == (short)InstallmentPlan.InstalmentMethod.IncreasingInstalment)
            {
                double coef = 1;
                int firstInstalment = 1;
                foreach (KeyValuePair<int, double> entry in collectionPlan.IncomeGrowthRate)
                {
                    coef = (1 + entry.Value / 100) * coef;
                    for (int i = firstInstalment - 1; i < entry.Key; i++)
                    {
                        collectionPlan.CoefList[i] = coef;
                    }
                    firstInstalment = entry.Key + 1;
                }
            }
            else if (collectionPlan.InstalmentMethod == (short)InstallmentPlan.InstalmentMethod.DecreasingInstalment)
            {
                double coef = 1;
                int firstInstalment = 1;
                foreach (KeyValuePair<int, double> entry in collectionPlan.IncomeGrowthRate)
                {
                    coef = (1 - entry.Value / 100) * coef;
                    for (int i = firstInstalment - 1; i < entry.Key; i++)
                    {
                        collectionPlan.CoefList[i] = coef;
                    }
                    firstInstalment = entry.Key + 1;
                }
            }
            else if (collectionPlan.InstalmentMethod == (short)InstallmentPlan.InstalmentMethod.AdditionalPayment && collectionPlan.ExInstalmentType == 2 )// (short)ExInstalmentType.Number)
            {
                for (int i = 0; i < collectionPlan.InstalmentCount; i++)
                {
                    if ((i + 1) % collectionPlan.InstalmentPeriod == collectionPlan.ExInstalmentPeriod % collectionPlan.InstalmentPeriod)
                    {
                        collectionPlan.CoefList[i] = 1 + (double)collectionPlan.ExInstalmentValue;
                    }
                    else
                    {
                        collectionPlan.CoefList[i] = 1;
                    }
                }
            }
            else if (collectionPlan.InstalmentMethod == (short)InstallmentPlan.InstalmentMethod.VariableAmount)
            {
                //bunlar için coeflist düzenlenmeyecek
            }
            else if (collectionPlan.InstalmentMethod == (short)InstallmentPlan.InstalmentMethod.VariablePrincipal)
            {
                //bunlar için coeflist düzenlenmeyecek
            }
            else
            {
                for (int i = 0; i < collectionPlan.InstalmentCount; i++)
                {
                    collectionPlan.CoefList[i] = 1;
                }
            }

            return collectionPlan;
        }

        #endregion
    }
}

