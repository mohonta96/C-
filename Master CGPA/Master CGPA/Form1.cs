namespace Master_CGPA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clear();
        }

        public void Clear()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();
            textBox13.Clear();
            textBox14.Clear();
            textBox15.Clear();
            textBox16.Clear();
            textBox17.Clear();
            textBox18.Clear();
            textBox19.Clear();
            textBox20.Clear();
            textBox21.Clear();
            textBox22.Clear();
            textBox23.Clear();
            textBox24.Clear();
            textBox25.Clear();
            textBox26.Clear();
            textBox27.Clear();
            textBox28.Clear();
            textBox29.Clear();
            textBox30.Clear();
            textBox31.Clear();
            textBox32.Clear();
            textBox33.Clear();
            textBox34.Clear();
            textBox35.Clear();
            textBox36.Clear();
            textBox37.Clear();
            textBox38.Clear();
            textBox39.Clear();
            textBox40.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //variable declaration for marks;
            double sp, tc, dt, os, osl, adb, adbl, oopl, na, total;

            //variable declaration for credit per subject;
            double spc, tcc, dtc, osc, oslc, adbc, adblc, ooplc, nac, gpa, avg, mul, total_credit;

            //padoubletable variable 
            double a, b, c, d, ee, f, g, h, i;

            try
            {
                //variable initialization for mark;
                sp = double.Parse(textBox1.Text);
                tc = double.Parse(textBox2.Text);
                dt = double.Parse(textBox3.Text);
                os = double.Parse(textBox4.Text);
                osl = double.Parse(textBox5.Text);
                adb = double.Parse(textBox6.Text);
                adbl = double.Parse(textBox7.Text);
                oopl = double.Parse(textBox8.Text);
                na = double.Parse(textBox9.Text);

                //variable initialization for credit;
                spc = double.Parse(textBox10.Text);
                tcc = double.Parse(textBox11.Text);
                dtc = double.Parse(textBox12.Text);
                osc = double.Parse(textBox13.Text);
                oslc = double.Parse(textBox14.Text);
                adbc = double.Parse(textBox15.Text);
                adblc = double.Parse(textBox16.Text);
                ooplc = double.Parse(textBox17.Text);
                nac = double.Parse(textBox18.Text);

                //for showing the Grade double the text box from textbox19;
                textBox19.Text = Grade(sp);
                textBox20.Text = Grade(tc);
                textBox21.Text = Grade(dt);
                textBox22.Text = Grade(os);
                textBox23.Text = Grade(osl);
                textBox24.Text = Grade(adb);
                textBox25.Text = Grade(adbl);
                textBox26.Text = Grade(oopl);
                textBox27.Text = Grade(na);



                //for showing podoubletable from txtBox28;
                textBox28.Text = Point(sp).ToString();
                textBox29.Text = Point(tc).ToString();
                textBox30.Text = Point(os).ToString();
                textBox31.Text = Point(osl).ToString();
                textBox32.Text = Point(dt).ToString();
                textBox33.Text = Point(adb).ToString();
                textBox34.Text = Point(adbl).ToString();
                textBox35.Text = Point(oopl).ToString();
                textBox36.Text = Point(na).ToString();

                //geting podoublefrom mark;
                a = Point(sp);
                b = Point(tc);
                c = Point(os);
                d = Point(osl);
                ee = Point(dt);
                f = Point(adb);
                g = Point(adbl);
                h = Point(oopl);
                i = Point(na);



                //for total calculation mark;
                total = sp + tc + dt + os + osl + adb + adbl + oopl + na;
                textBox38.Text = total.ToString();

                //total credit;
                total_credit = spc + tcc + dtc + osc + oslc + adbc + adblc + ooplc + nac;

                //for Average mark;
                avg = total / 9;
                textBox37.Text = avg.ToString();
                textBox39.Text = Point(avg).ToString();
                double xx = Point(avg);
                textBox40.Text = Grade_D(xx);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                MessageBox.Show("Successfuly CalCulate, Thank You", "Calculation");
            }

            ////variable initialization for mark;
            //sp = double.Parse(textBox1.Text);
            //tc = double.Parse(textBox2.Text);
            //dt = double.Parse(textBox3.Text);
            //os = double.Parse(textBox4.Text);
            //osl = double.Parse(textBox5.Text);
            //adb = double.Parse(textBox6.Text);
            //adbl = double.Parse(textBox7.Text);
            //oopl = double.Parse(textBox8.Text);
            //na = double.Parse(textBox9.Text);

            ////variable initialization for credit;
            //spc = double.Parse(textBox10.Text);
            //tcc = double.Parse(textBox11.Text);
            //dtc = double.Parse(textBox12.Text);
            //osc = double.Parse(textBox13.Text);
            //oslc = double.Parse(textBox14.Text);
            //adbc = double.Parse(textBox15.Text);
            //adblc = double.Parse(textBox16.Text);
            //ooplc = double.Parse(textBox17.Text);
            //nac = double.Parse(textBox18.Text);

            ////for showing the Grade double the text box from textbox19;
            //textBox19.Text = Grade(sp);
            //textBox20.Text = Grade(tc);
            //textBox21.Text = Grade(dt);
            //textBox22.Text = Grade(os);
            //textBox23.Text = Grade(osl);
            //textBox24.Text = Grade(adb);
            //textBox25.Text = Grade(adbl);
            //textBox26.Text = Grade(oopl);
            //textBox27.Text = Grade(na);



            ////for showing podoubletable from txtBox28;
            //textBox28.Text = Point(sp).ToString();
            //textBox29.Text = Point(tc).ToString();
            //textBox30.Text = Point(os).ToString();
            //textBox31.Text = Point(osl).ToString();
            //textBox32.Text = Point(dt).ToString();
            //textBox33.Text = Point(adb).ToString();
            //textBox34.Text = Point(adbl).ToString();
            //textBox35.Text = Point(oopl).ToString();
            //textBox36.Text = Point(na).ToString();

            ////geting podoublefrom mark;
            //a = Point(sp);
            //b = Point(tc);
            //c = Point(os);
            //d = Point(osl);
            //ee = Point(dt);
            //f = Point(adb);
            //g = Point(adbl);
            //h = Point(oopl);
            //i = Point(na);



            ////for total calculation mark;
            //total = sp + tc + dt + os + osl + adb + adbl + oopl + na;
            //textBox38.Text = total.ToString();

            ////total credit;
            //total_credit = spc + tcc + dtc + osc + oslc + adbc + adblc + ooplc + nac;

            ////for Average mark;
            //avg = total / 9;
            //textBox37.Text = avg.ToString();
            //textBox39.Text = Point(avg).ToString();
            //double xx = Point(avg);
            //textBox40.Text = Grade_D(xx);

            //Cgpa Weight 
            //mul = (a * spc) + (b * tcc) + (c * dtc) + (d * osc) + (ee * oslc) + (f * adbc) + (g * adbl) + (h * ooplc) + (i * nac);

            //Cgpa Podouble
            //gpa = mul / total_credit;
            //textBox39.Text = gpa.ToString();

            //Total Grade
            //textBox40.Text = (gpa).ToString();


        }

        public string Grade(double mark)
        {
            if (mark >= 80)
            {
                return "A+";
            }
            else if (mark >= 75 && mark <= 80)
            {
                return "A";
            }
            else if (mark >= 70 && mark <= 75)
            {
                return "A-";
            }
            else if (mark >= 65 && mark <= 70)
            {
                return "A+";
            }
            else if (mark >= 60 && mark <= 65)
            {
                return "B";
            }
            else if (mark >= 55 && mark <= 60)
            {
                return "B-";
            }
            else if (mark >= 50 && mark <= 55)
            {
                return "C+";
            }
            else if (mark >= 45 && mark <= 50)
            {
                return "C";
            }
            else if (mark >= 40 && mark <= 45)
            {
                return "D";
            }
            else
            {
                return "F";
            }
        }

        public double Point(double mark)
        {
            if (mark >= 80)
            {
                return 4.0;
            }
            else if (mark >= 75 && mark <= 80)
            {
                return 3.75;
            }
            else if (mark >= 70 && mark <= 75)
            {
                return 3.5;
            }
            else if (mark >= 65 && mark <= 70)
            {
                return 3.25;
            }
            else if (mark >= 60 && mark <= 65)
            {
                return 3.0;
            }
            else if (mark >= 55 && mark <= 60)
            {
                return 2.75;
            }
            else if (mark >= 50 && mark <= 55)
            {
                return 2.5;
            }
            else if (mark >= 45 && mark <= 50)
            {
                return 2.25;
            }
            else if (mark >= 40 && mark <= 45)
            {
                return 2.0;
            }
            else
            {
                return 0.0;
            }
        }

        public string Grade_D(double point)
        {
            if (point == 4.0)
            {
                return "A+";
            }
            else if (point == 3.75)
            {
                return "A";
            }
            else if (point == 3.5)
            {
                return "A-";
            }
            else if (point == 3.25)
            {
                return "B+";
            }
            else if (point == 3.0)
            {
                return "B";
            }
            else if (point == 2.75)
            {
                return "B-";
            }
            else if (point == 2.5)
            {
                return "C+";
            }
            else if (point == 2.25)
            {
                return "C";
            }
            else if (point == 2.0)
            {
                return "D";
            }
            else
            {
                return "F";
            }
        }
    }
}