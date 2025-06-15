using longgame;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace longgame
{
    public class chero
    {
        public int x, y;
        public List<Bitmap> img = new List<Bitmap>();
        public int frame;
        public int flag = 0;


    }
    public class Cimg
    {
        public int X, Y, W, H;
        public Bitmap img;
        public Rectangle rcDst, rcSrc;
        public string s = "";


    }


    public class churt
    {

        public int x, y;
        public List<Bitmap> img = new List<Bitmap>();
        public int frame = 0;

    }


    public class coin
    {

        public int x, y;
        public List<Bitmap> img = new List<Bitmap>();
        public int frame = 0;

    }

    public class allcoin
    {
        public int x, y;
        public Bitmap img;
        public int flag = 1;
    }


    public class cbomb
    {
        public int x, y;
        public Bitmap img;
        public int flag = 1;
    }

    public class Claser
    {
        public int X, Y, W, H;
        public int flag;

    }

    public class crec
    {
        public int x, y, w, h;
        public int dir = 1;

    }


    public class staticanami
    {

        public int x, y;
        public Bitmap img;
        public int frame = 1;
        public int flag = 1;


    }


    public class fireanami
    {

        public int x, y;
        public Bitmap img;
        public int frame;


    }


    public class upland
    {
        public int x, y;
        public Bitmap img;
        public int frame;

    }



    public class cobst
    {
        public int x, y;
        public Bitmap img;
        public int frame;


    }


    public class cland
    {
        public int x, y;
        public Bitmap img;
        public int frame;
        public Rectangle rcDst, rcSrc;

    }


    public class cladder
    {
        public int x, y;
        public Bitmap img;
        public int frame;
        public int flag = 0;


    }



    public class cback
    {
        public Rectangle rcDst, rcSrc;
        public int x, y;
        public Bitmap img;
        public int frame;


    }

    public class bolt
    {
        public int x, y;

        public List<Bitmap> img = new List<Bitmap>();
        public int frame;
        public int flag = 0;
    }

    public partial class Form1 : Form
    {

        List<chero> hero = new List<chero>();
        List<cback> back = new List<cback>();
        List<cobst> obstacles = new List<cobst>();
        List<cladder> ladders = new List<cladder>();
        List<staticanami> staticanamis = new List<staticanami>();
        List<fireanami> fireanamis = new List<fireanami>();
        List<cland> land = new List<cland>();
        List<upland> upland = new List<upland>();
        List<upland> upland2 = new List<upland>();
        List<crec> elevator = new List<crec>();
        List<cbomb> bomb = new List<cbomb>();
        List<churt> hurt = new List<churt>();

        List<coin> coins = new List<coin>();
        List<allcoin> allcoins = new List<allcoin>();



        List<Cimg> lwin = new List<Cimg>();
        List<Cimg> lgameover = new List<Cimg>();

        List<Claser> laser = new List<Claser>();
        List<Claser> laser2 = new List<Claser>();

        List<chero> heroidle = new List<chero>();
        List<chero> heroturn = new List<chero>();
        List<chero> herowalk = new List<chero>();
        List<chero> herorun = new List<chero>();
        List<chero> herohurt = new List<chero>();
        List<chero> herodead = new List<chero>();
        List<chero> herojump = new List<chero>();
        List<chero> heroattack = new List<chero>();
        List<chero> herofire = new List<chero>();
        List<bolt> bolts = new List<bolt>();
        Bitmap off;
        int flagbolt = 0;
        Timer t = new Timer();
        int flagjump = 0;
        int ct = 0;
        int ctbolt = 0; int flag = 0;
        int fcatch = 0;
        int flagstartfire = 0;
        int flagstopfire = 0;
        int flagstopfire2 = 0;
        int xoldfire = 0;
        int c = 0, a = 0;
        int flagland = 0, flagupland = 0, flagelevator = 0;
        int flagland2 = 0, flagupland2 = 0, flagelevator2 = 0;
        int flaggraphity = 0;
        int check = 0;
        int ctframe = 0;
        int flaglaser;
        int cttlaser = 0;
        int flagan = 0;
        
        int stop = 0;
        int ctt = 0;
        int flagbomb = 0;
        int ctbomb = 0;
        int cthurt = 0;
        int ctcoin = 0;
        int flagcoin = 0;
        int ctfly = 0;
        int down = 0;
        int x = 0;
        int ctmoney = 0, ctgameover = 0;
        int flagwin = 0;
        int ctlaser = 0;
        int ctrun = 0;
        int flaggameover = 0;
        int flagleftjump = 0;
        int cttick = 0;
        Random r = new Random();
        public Form1()
        {
            this.WindowState = FormWindowState.Maximized;
            this.BackColor = Color.Black;
            this.Paint += Form1_Paint;
            this.KeyDown += Form1_KeyDown;
            this.Load += Form1_Load1;
            //  this.WindowState = FormWindowState.Maximized;
            t.Tick += T_Tick;
            t.Interval = 1;
            t.Start();
            //  InitializeComponent();
        }



        private void Form1_Load1(object sender, EventArgs e)
        {
            off = new Bitmap(this.ClientSize.Width, this.ClientSize.Height);

            createobstacles();
            createladder();

            createstaticanami();
            createfireanami();

            createhero();
            createbomb();

            drawback();

            // createhurt();
            createhurt();

            createallcoin();
            createcoin();


            createelevator();

            createupland();

        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int ctt = 0;
            if (e.KeyCode == Keys.F)
            {
                createbolt();
                flagstartfire = 1;
                flagjump = 0;
                check = 0;

                //  this.Text = ("" + bolts.Count);
            }
            else
            {

                ctframe = 0;
            }

            if (e.KeyCode == Keys.Space)
            {
                flagjump = 1;

                check = 0;

            }
            else
            {
                flagjump = 0;
                //  hero[0].frame = 6;

            }

            if (e.KeyCode == Keys.Q)
            {
                flagleftjump = 1;


                check = 0;

            }
            else
            {
                flagleftjump = 0;
                //  hero[0].frame = 6;

            }

            if (e.KeyCode == Keys.Right)
            {
                if (hero[0].x < back[0].img.Width - 10)
                {
                    hero[0].x += 5;

                }
                if (hero[0].x > back[0].rcSrc.Width)
                {
                    hero[0].x = back[0].rcSrc.Width - 50;
                }
                back[0].rcSrc.X += 30;
                land[0].rcSrc.X += 30;
                if (back[0].rcSrc.X < 0)
                    back[0].rcSrc.X = 0;

                if (back[0].rcSrc.Y < 0)
                    back[0].rcSrc.Y = 0;

                if (back[0].rcSrc.X + this.ClientSize.Width > back[0].img.Width)
                {
                    back[0].rcSrc.X = back[0].img.Width - this.ClientSize.Width;
                }
                if (back[0].rcSrc.Y + this.ClientSize.Height > back[0].img.Height)
                {
                    back[0].rcSrc.Y = back[0].img.Height - this.ClientSize.Height;
                }
                if (hero[0].frame > 5 && hero[0].frame < 12)
                {
                    // MessageBox.Show("good" + this.Width + "    " + this.Height);
                    //  herowalk[0].frame++;


                    hero[0].frame++;


                }
                else
                {
                    //  this.Text = ("" + hero[0].frame);
                    hero[0].frame = 7;

                }

                check = 1;
                flagjump = 0;
                flagleftjump = 0;



            }
            else
            {
                // ctbolt = 0;

            }

            if (e.KeyCode == Keys.Left)
            {
                check = 1;
                if (hero[0].x > 10)
                {
                    hero[0].x -= 5;

                }
                if (hero[0].x < 0)
                {
                    hero[0].x = 0;
                }
                back[0].rcSrc.X -= 10;
                land[0].rcSrc.X = back[0].rcSrc.X;



                if (hero[0].frame > 42 && hero[0].frame < 47)
                {
                    // MessageBox.Show("good" + this.Width + "    " + this.Height);
                    //  herowalk[0].frame++;


                    hero[0].frame++;


                }
                else
                {
                    //  this.Text = ("" + hero[0].frame);
                    hero[0].frame = 43;

                }

                check = 1;
                flagjump = 0;
                flagleftjump = 0;


            }


            if (e.KeyCode == Keys.Up)
            {
                int a = checkladder();
                if (a == -1)
                {
                    // MessageBox.Show(ladders[0].x + "");
                }
                else
                {
                    if (ladders[a].flag == 1)
                    {

                        hero[0].y -= 5;
                        hero[0].x++;

                    }

                    if (ladders[a].flag == -1)
                    {

                        hero[0].y -= 5;
                        hero[0].x--;

                    }

                    if (ladders[a].flag == 0)
                    {

                        hero[0].y -= 10;


                    }

                    hero[0].frame = 49;


                }
                check = 0;
                flagjump = 0;
                flagleftjump = 0;


            }
            else
            {
                // hero[0].frame = 6;

            }

            if (e.KeyCode == Keys.Down)
            {
                int a = checkladder();
                if (a == -1)
                {
                    // MessageBox.Show(ladders[0].x + "");
                }
                else
                {
                    if (ladders[a].flag == 1)
                    {

                        hero[0].y += 2;
                        hero[0].x--;

                    }

                    if (ladders[a].flag == -1)
                    {

                        hero[0].y += 2;
                        hero[0].x++;

                    }

                    if (ladders[a].flag == 0)
                    {

                        hero[0].y += 10;


                    }

                    hero[0].frame = 49;


                }
                check = 0;
                flagjump = 0;

            }
            else
            {
                // hero[0].frame = 6;

            }

            if (e.KeyCode == Keys.R)
            {
                if (ctrun == 0)
                {
                    back[0].rcSrc.X += 100;
                    land[0].rcSrc.X += 100;
                }
                else
                {
                    back[0].rcSrc.X += 20 + ctrun;
                    land[0].rcSrc.X += 20 + ctrun;
                }


                hero[0].x += 10;
                if (hero[0].x < back[0].img.Width - 30)
                {
                    // hero[0].x += 30;

                }
                if (hero[0].x > back[0].rcSrc.Width)
                {
                    hero[0].x = back[0].rcSrc.Width - 50;
                }

                if (back[0].rcSrc.X < 0)
                    back[0].rcSrc.X = 0;

                if (back[0].rcSrc.Y < 0)
                    back[0].rcSrc.Y = 0;

                if (back[0].rcSrc.X + this.ClientSize.Width > back[0].img.Width)
                {
                    back[0].rcSrc.X = back[0].img.Width - this.ClientSize.Width;
                }
                if (back[0].rcSrc.Y + this.ClientSize.Height > back[0].img.Height)
                {
                    back[0].rcSrc.Y = back[0].img.Height - this.ClientSize.Height;
                }
                if (hero[0].frame > 12 && hero[0].frame < 18)
                {


                    hero[0].frame++;


                }
                else
                {
                    hero[0].frame = 13;

                }

                ctrun++;
            }



            if (e.KeyCode == Keys.W)
            {
                if (hero[0].y >= 10)
                {
                    hero[0].frame = 50;
                    down = 0;
                    hero[0].y -= 30;

                }
            }



            if (e.KeyCode == Keys.S)
            {
                if (hero[0].y < this.ClientSize.Height - 10)
                {
                    hero[0].frame = 51;
                    down = 1;

                    hero[0].y += 30;

                }
            }


            if ((e.KeyCode == Keys.L))
            {

                flaglaser = 1;
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            DrawDubb(CreateGraphics());

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            off = new Bitmap(this.ClientSize.Width, this.ClientSize.Height);

            createobstacles();
            createladder();
            createhurt();
            createstaticanami();
            createfireanami();
            createbomb();
            createhero();
            createallcoin();
            createcoin();
            drawback();

        }

        private void T_Tick(object sender, EventArgs e)
        {



            if (flagleftjump == 1)
            {
                if (ct < 30)
                {
                    if (ct == 0)
                    {
                        hero[0].frame = 53;
                        hero[0].x -= 5;
                        hero[0].y -= 20;

                    }
                    if (ct >= 1 && ct < 15)
                    {
                        hero[0].frame = 54;

                        hero[0].x -= 5;
                        hero[0].y -= 20;

                    }
                    else
                    {
                        if (ct % 2 == 0)
                        {
                            hero[0].frame = 57;
                            hero[0].x -= 5;
                            hero[0].y -= 5;
                        }
                        else
                        {
                            hero[0].frame = 57;
                            hero[0].x -= 5;
                            hero[0].y += 5;
                        }


                    }













                }
                else
                {
                    if (ct == 20)
                    {
                        hero[0].frame = 55;

                    }

                    int a = checkwhere();
                    if (a == -1)
                    {
                        hero[0].frame = 56;

                        if (flagelevator2 == 1)
                        {
                            hero[0].flag = 1;
                            //   hero[0].frame = 6;

                        }
                        else
                        {
                            hero[0].flag = 0;

                        }


                        flagelevator = 0;
                        flagleftjump = 0;
                        ct = 0;
                        flagland = 0;
                        flagupland = 0;
                    }
                    else
                    {

                        hero[0].x -= 5;
                        hero[0].y += 20;
                    }


                    ctframe++;

                }
                ct++;
            }

            /////////////////////////
            if (cttick % 50 ==0 )
            {

                if (staticanamis[0].flag == 1)
                {


                    Claser pnn2 = new Claser();
                    pnn2.X = staticanamis[0].x - 400;
                    pnn2.Y = staticanamis[0].img.Height / 2 + staticanamis[0].y + 1;
                    pnn2.W = 400;
                    pnn2.H = 5;
                    pnn2.flag = 1;
                    laser2.Add(pnn2);


                    if (true)
                    {

                    }


                    if ( laser2[0].Y >= hero[0].y && laser2[0].Y <= hero[0].y + hero[0].img[0].Height && laser2[0].X - back[0].rcSrc.X >= hero[0].x && laser2[0].X - back[0].rcSrc.X <= hero[0].img[0].Width + hero[0].x +10)
                    {
                      //  MessageBox.Show("hsaddgagdjasajs");
                        flagan = 1;
                        
                    }

                    //if (hero[0].x >= laser2[0].X && hero[0].x <= laser2[0].X + laser[0].W &&
                    //            laser2[0].Y >= hero[0].y && laser2[0].Y <= hero[0].y + hero[0].img[0].Height)
                    //{
                    //    hero[0].x -= 5;
                    //    for (int i = 0; i < 30; i++)
                    //    {
                    //        if (i == 0)
                    //        {
                    //            hero[0].frame = 39;
                    //        }

                    //        if (i == 5)
                    //        {
                    //            hero[0].frame = 40;

                    //        }


                    //        if (i == 10)
                    //        {
                    //            hero[0].frame = 41;

                    //        }


                    //        if (i == 20)
                    //        {
                    //            hero[0].frame = 42;

                    //        }

                    //        if (i == 29)
                    //        {
                    //            hero[0].frame = 6;

                    //        }
                    //    }


                    //}
                }
              
               



            }

            if (flagan==1)
            {
                hero[0].x -= 5;


                if (cttlaser < 30)
                {


                    if (cttlaser == 0)
                    {
                        if (cthurt < 5)
                        {
                            hurt[0].frame++;

                        }

                        hero[0].frame = 39;
                    }

                    if (cttlaser == 5)
                    {
                        hero[0].frame = 40;

                    }


                    if (cttlaser == 10)
                    {
                        hero[0].frame = 41;

                    }


                    if (cttlaser == 20)
                    {
                        hero[0].frame = 42;

                    }

                    if (cttlaser == 29)
                    {
                        hero[0].frame = 6;

                    }
                    cttlaser++;
                }
                else
                {
                    
                    flagan = 0;
                    cttlaser = 0; 
                }

            }
            if (cttick % 70 == 0 || staticanamis[0].flag==0)
            {
                for (int i = 0; i < laser2.Count; i++)
                {
                    laser2[i].flag = 0;
                }
            }
            ///////////////////////////////////////////////////

            if (flaglaser == 1)
            {
                if (ctlaser == 0)
                {
                    hero[0].frame = 26;
                }

                if (ctlaser == 5)
                {
                    hero[0].frame = 27;
                }

                if (ctlaser == 15)
                {
                    hero[0].frame = 28;
                }

                if (ctlaser == 25)
                {
                    hero[0].frame = 29;

                }
                if (ctlaser == 30)
                {
                    Claser pnn2 = new Claser();
                    pnn2.X = hero[0].x + hero[0].img[0].Width + 10;
                    pnn2.Y = hero[0].img[0].Height / 2 + hero[0].y + 1;
                    pnn2.W = 600;
                    pnn2.H = 5;
                    pnn2.flag = 1;
                    laser.Add(pnn2);



                }

                if (ctlaser == 40)
                {
                    //  laser[laser.Count - 1].flag = 0;
                    for (int i = 0; i < staticanamis.Count; i++)
                    {







                        if (staticanamis[i].x - back[0].rcSrc.X >= laser[0].X && staticanamis[i].x - back[0].rcSrc.X <= laser[0].X + laser[0].W &&
                            laser[0].Y >= staticanamis[i].y && laser[0].Y <= staticanamis[i].y + staticanamis[i].img.Height)
                        {
                            staticanamis[i].frame = 0;
                            staticanamis[i].flag = 0;
                        }
                    }

                    for (int i = 0; i < laser.Count; i++)
                    {
                        laser[i].flag = 0;
                    }

                    flaglaser = 0;
                    hero[0].frame = 6;
                    ctlaser = 0;
                }

                ctlaser++;
            }

            //////////////////////
            ///
            /// /////////////////// graphity 
            ///


            if (check == 1)
            {



                int a = checkwhere();
                if (a == -1)
                {

                    if (flagelevator2 == 1)
                    {
                        hero[0].flag = 1;
                        //   hero[0].frame = 6;

                    }
                    else
                    {
                        hero[0].flag = 0;

                    }

                    flagelevator2 = 0;
                    flagjump = 0;
                    ct = 0;
                    flagland2 = 0;
                    flagupland2 = 0;
                }
                else
                {
                    //hero[0].frame = 6;

                    hero[0].x += 5;
                    hero[0].y += 20;
                }






            }


            /**///////////////////////////////// jmp logic 

            if (flagjump == 1)
            {
                if (ct < 15)
                {
                    if (ct == 0)
                    {
                        hero[0].frame = 22;

                    }
                    if (ct >= 1 && ct < 10)
                    {
                        hero[0].frame = 23;

                    }






                    hero[0].x += 5;
                    hero[0].y -= 20;



                }
                else
                {
                    if (ct == 15)
                    {
                        hero[0].frame = 24;

                    }

                    int a = checkwhere();
                    if (a == -1)
                    {
                        hero[0].frame = 25;

                        if (flagelevator2 == 1)
                        {
                            hero[0].flag = 1;
                            //   hero[0].frame = 6;

                        }
                        else
                        {
                            hero[0].flag = 0;

                        }


                        flagelevator = 0;
                        flagjump = 0;
                        ct = 0;
                        flagland = 0;
                        flagupland = 0;
                    }
                    else
                    {

                        hero[0].x += 5;
                        hero[0].y += 20;
                    }


                    ctframe++;

                }
                ct++;
            }
            cttick++;
            /////////////////////////////////////////////////////////////
            /**/////// logic move fire and stop it ( sengel fire ) 

            if (flagstartfire == 1)
            {

                if (ctframe == 0)
                {
                    xoldfire = bolts[0].x;
                    hero[0].frame = 30;
                }


                if (ctframe == 1)
                {
                    hero[0].frame = 31;
                }


                if (ctframe == 2)
                {
                    hero[0].frame = 32;
                }

                if (ctframe == 3)
                {
                    hero[0].frame = 33;
                }

                if (ctframe == 4)
                {
                    hero[0].frame = 34;
                }

                if (ctframe == 5)
                {
                    hero[0].frame = 35;
                }

                if (ctframe == 6)
                {
                    hero[0].frame = 36;
                }

                if (ctframe == 7)
                {
                    hero[0].frame = 37;

                }


                if (ctbolt > 8)
                {
                    bolts[bolts.Count - 1].flag = 1;



                    flagstartfire = 0;
                    ctframe = 0;
                    ctbolt = 0;
                    hero[0].frame = 6;
                }
                else
                {
                    ctframe++;
                    ctbolt++;
                }







            }


            ///////////////////////////////////////
            ///
            /// this.Text = ("" + back[0].rcSrc.X + "     left" + land[0].rcSrc.X);



            ///////////////////////////////////



            for (int i = 0; i < bolts.Count; i++)
            {
                if (bolts[i].flag == 1)
                {


                    for (int k = 0; k < staticanamis.Count; k++)
                    {
                        if (staticanamis[k].flag == 1)
                        {


                            if (bolts[i].x >= staticanamis[k].x - 20 - back[0].rcSrc.X && bolts[i].x <= (staticanamis[k].x + staticanamis[k].img.Width + 20) - back[0].rcSrc.X

                                && bolts[i].y >= staticanamis[k].y && bolts[i].y <= (staticanamis[k].y + staticanamis[k].img.Height)
                                )
                            {
                                bolts[i].flag = 0;
                                staticanamis[k].frame = 0;
                                staticanamis[k].flag = 0;
                                stop = 1;
                            }
                        }
                    }

                    if (bolts[i].x > hero[0].x + hero[0].img[0].Width + 200)
                    {

                        bolts[i].frame = 1;
                    }

                    if (bolts[i].x > hero[0].x + hero[0].img[0].Width + 300)
                    {

                        bolts[i].frame = 2;
                    }

                    if (bolts[i].x > hero[0].x + hero[0].img[0].Width + 400)
                    {

                        bolts[i].frame = 3;
                    }


                    if (bolts[i].x > hero[0].x + hero[0].img[0].Width + 500)
                    {
                        stop = 1;
                        bolts[i].frame = 4;

                        bolts[i].flag = 0;
                    }




                    bolts[i].x += 10;




                }



            }

            ///////////////////////////////////////////////////
            /**/ /// move elevator 

            for (int i = 0; i < elevator.Count; i++)
            {
                if (elevator[i].dir == 1)
                {
                    if (hero[0].flag == 1)
                    {
                        hero[i].x += 10;

                    }
                    elevator[i].x += 10;
                }
                else
                {
                    if (hero[0].flag == 1)
                    {
                        hero[i].x -= 10;

                    }
                    elevator[i].x -= 10;

                }

                if (elevator[i].x >= 750)
                {
                    elevator[i].dir *= -1;
                }
                if (elevator[i].x <= 350)
                {
                    elevator[i].dir *= -1;

                }
            }
            ////
            
            collectcoin();
            checkbomb();
            if (flagcoin == 1)
            {

                if (coins[0].frame < 3)
                {
                    coins[0].frame++;


                }

                ctcoin = 0;
                flagcoin = 0;

            }
            if (flagbomb == 1)
            {
                hero[0].x -= 5;

               
                if (ctbomb < 30)
                {


                    if (ctbomb == 0)
                    {
                        if (cthurt < 5)
                        {
                            hurt[0].frame++;

                        }
                        hero[0].frame = 39;
                    }

                    if (ctbomb == 5)
                    {
                        hero[0].frame = 40;

                    }


                    if (ctbomb == 10)
                    {
                        hero[0].frame = 41;

                    }


                    if (ctbomb == 20)
                    {
                        hero[0].frame = 42;

                    }

                    if (ctbomb == 29)
                    {
                        hero[0].frame = 6;

                    }
                    ctbomb++;
                }
                else
                {
                    ctbomb = 0;
                    flagbomb = 0;
                    ctgameover++;
                }


            }
            ///////
            ///


            if (back[0].rcSrc.X >= 2700)
            {



                check = 0;
                if (down == 0)
                {
                    hero[0].frame = 50;

                }
                else
                {
                    hero[0].frame = 51;

                }
                if (ctfly == 1)
                {


                    hero[0].y = this.Height / 2;
                    //  back[0].rcSrc.X += 200;
                    // land[0].rcSrc.X += 200;
                }
                else
                {
                    hero[0].x += 1;

                    back[0].rcSrc.X += 40;
                    land[0].rcSrc.X += 40;
                    if (back[0].rcSrc.X < 0)
                        back[0].rcSrc.X = 0;
                    land[0].rcSrc.X = 0;

                    if (back[0].rcSrc.Y < 0)
                        back[0].rcSrc.Y = 0;
                    land[0].rcSrc.Y = 0;

                    if (back[0].rcSrc.X + this.ClientSize.Width > back[0].img.Width)
                    {

                        flagwin = 1;
                        Cimg pnn = new Cimg();
                        pnn.X = 0;
                        pnn.Y = 0;
                        pnn.img = new Bitmap("winner.png");
                        pnn.rcSrc = new Rectangle(0, 0, this.ClientSize.Width, this.ClientSize.Height);
                        pnn.rcDst = new Rectangle(0, 0, this.ClientSize.Width, this.ClientSize.Height);
                        lwin.Add(pnn);

                        back[0].rcSrc.X = back[0].img.Width - this.ClientSize.Width;
                        land[0].rcSrc.X = back[0].img.Width - this.ClientSize.Width;
                    }
                    if (back[0].rcSrc.Y + this.ClientSize.Height > back[0].img.Height)
                    {
                        back[0].rcSrc.Y = back[0].img.Height - this.ClientSize.Height;
                        land[0].rcSrc.Y = back[0].img.Height - this.ClientSize.Height;
                    }
                }


                ctfly++;


            }

            if (hurt[0].frame >= 5)
            {
                t.Stop();

                flaggameover = 1;
                Cimg pnn = new Cimg();
                pnn.X = 0;
                pnn.Y = 0;
                pnn.img = new Bitmap("gameover.png");
                pnn.rcSrc = new Rectangle(0, 0, this.ClientSize.Width, this.ClientSize.Height);
                pnn.rcDst = new Rectangle(0, 0, this.ClientSize.Width, this.ClientSize.Height);
                lgameover.Add(pnn);
            }

            //if (back[0].rcSrc.X > 7667)
            //{
            //    t.Stop();
            //    win();
            //}

            DrawDubb(CreateGraphics());

        }
        /////////////
        ///
        void win()
        {
            flagwin = 1;
            Cimg pnn = new Cimg();
            pnn.X = 0;
            pnn.Y = 0;
            pnn.img = new Bitmap("winner.png");
            pnn.rcSrc = new Rectangle(0, 0, this.ClientSize.Width, this.ClientSize.Height);
            pnn.rcDst = new Rectangle(0, 0, this.ClientSize.Width, this.ClientSize.Height);
            lwin.Add(pnn);
        }
        /**/ ////////////////// checking ////////////////////////////////////////////////////

        /**/ /// for single fire 
        int checkrange(int x, int i)
        {

            if (bolts[i].x > x + 400)
            {
                flagstopfire = 1;
            }

            if (bolts[i].x >= x + 300)
            {
                bolts[i].frame = 3;
            }

            if (bolts[i].x == x + 400)
            {
                return 1;
            }

            return -1;
        }


        int checkanimes(int k)
        {
            for (int i = 0; i < staticanamis.Count; i++)
            {
                if (staticanamis[i].flag == 1)
                {
                    if (



                        bolts[k].x <= (staticanamis[i].x + staticanamis[i].img.Width) - back[0].rcSrc.X
                        && bolts[k].x >= (staticanamis[i].x - back[0].rcSrc.X) && bolts[k].y >= staticanamis[i].y && bolts[k].y <= (staticanamis[i].y + staticanamis[i].img.Height)







                        )
                    {
                        return i;
                    }
                }
            }

            return -1;
        }



        int checkwhere()
        {

            for (int i = 0; i < elevator.Count; i++)
            {
                if (hero[0].x >= elevator[i].x - back[0].rcSrc.X && hero[0].x < (elevator[i].x + elevator[i].w) - back[0].rcSrc.X && hero[0].y + hero[0].img[0].Height >= elevator[i].y  && hero[0].y + hero[0].img[0].Height <

                    elevator[i].y + elevator[i].h)
                {
                    flagelevator2 = 1;

                }
                else
                {
                    flagelevator2 = 2;
                }
            }
            int q = 0;
            int w = 0;
            for (int i = 0; i < upland.Count; i++)
            {

                if (i == 0)
                {
                    if (hero[0].x >= upland[i].x - back[0].rcSrc.X && hero[0].x < (upland[i].x + upland[i].img.Width) - back[0].rcSrc.X && hero[0].y + hero[0].img[0].Height >= upland[i].y + 65 &&

                        hero[0].y + hero[0].img[0].Height <= upland[i].y + 80)
                    {
                        q = 1;
                        flagupland2 = 1;
                    }
                    else
                    {

                        flagupland2 = 2;

                    }
                }
                else
                {

                    if (hero[0].x >= upland[i].x - back[0].rcSrc.X && hero[0].x < (upland[i].x + upland[i].img.Width) - back[0].rcSrc.X && hero[0].y + hero[0].img[0].Height >= upland[i].y + 65 &&

                         hero[0].y + hero[0].img[0].Height <= upland[i].y + 80)
                    {


                        w = 1;
                        flagupland2 = 1;


                    }
                    else
                    {
                        flagupland2 = 2;
                    }
                }
            }


            for (int i = 0; i < upland2.Count; i++)
            {

                if (i == 0)
                {
                    if (hero[0].x >= upland2[i].x - back[0].rcSrc.X && hero[0].x < (upland2[i].x + upland2[i].img.Width) - back[0].rcSrc.X && hero[0].y + hero[0].img[0].Height >= upland2[i].y + 65 &&

                        hero[0].y + hero[0].img[0].Height <= upland2[i].y + 80)
                    {
                        q = 1;
                        flagupland2 = 1;
                    }
                    else
                    {

                        flagupland2 = 2;

                    }
                }
                else
                {

                    if (hero[0].x >= upland2[i].x - 50 - back[0].rcSrc.X && hero[0].x < (upland2[i].x + upland2[i].img.Width) - back[0].rcSrc.X && hero[0].y + hero[0].img[0].Height >= upland2[i].y + 65 &&

                        hero[0].y + hero[0].img[0].Height <= upland2[i].y + 80)
                    {

                        // this.Text = ("upland");
                        flagupland2 = 1;


                    }
                    else
                    {
                        flagupland2 = 2;
                    }
                }
            }



            if (hero[0].y > 700 && hero[0].y < 800)
            {
                flagland2 = 1;

            }
            else
            {
                flagland2 = 2;
            }

            if (flagupland2 == 1)
            {

                q = 1;
            }

            if (flagland2 == 2 && flagupland2 == 2 && flagelevator2 == 2 && q == 0 && w == 0)
            {

                return 1;
            }
            else
            {


                return -1;
            }



        }
        /**////////////////////////////




        void checkgraphity()
        {
            int go;
            for (int i = 0; i < elevator.Count; i++)
            {
                if (hero[0].x >= elevator[i].x && hero[0].x < elevator[i].x + elevator[i].w && hero[0].y + hero[0].img[0].Height > elevator[i].y - 50 && hero[0].y <

                        elevator[i].y + elevator[i].h)
                {
                    flagelevator = 1;
                }
            }

            //for (int i = 0; i < upland.Count; i++)
            //{
            //    if (hero[0].x >= upland[i].x - back[0].rcSrc.X && hero[0].x < (upland[i].x + upland[i].img.Width) - back[0].rcSrc.X && hero[0].y >= upland[i].y - hero[0].img[0].Height + 20)
            //    {
            //        flagupland = 1;
            //    }
            //}


            for (int i = 0; i < upland.Count; i++)
            {
                if (hero[0].y <= upland[i].y - hero[0].img[0].Height)
                {
                    flagupland = 1;
                }
            }


            //for (int i = 0; i < land.Count; i++)
            //{
            //    if (hero[0].x >= land[i].x && hero[0].x < land[i].x + land[i].img.Width && hero[0].y == land[i].y - 50 )
            //    {
            //        flagland = 1;
            //    }
            //}


            if (hero[0].y > 700)
            {
                flagland = 1;

            }



        }




        int checkgraphity2()
        {
            //int go;
            for (int i = 0; i < elevator.Count; i++)
            {
                if (hero[0].x >= elevator[i].x - back[0].rcSrc.X && hero[0].x < (elevator[i].x + elevator[i].w) - back[0].rcSrc.X && hero[0].y > elevator[i].y - 50 && hero[0].y <

                        elevator[i].y + elevator[i].h)
                {
                    flagelevator2 = 1;
                }
            }

            for (int i = 0; i < upland.Count; i++)
            {
                if (hero[0].x >= upland[i].x - back[0].rcSrc.X && hero[0].x < (upland[i].x + upland[i].img.Width) - back[0].rcSrc.X && hero[0].y >= upland[i].y - hero[0].img[0].Height + 20)
                {
                    flagupland2 = 1;
                }
            }


            ////for (int i = 0; i < land.Count; i++)
            ////{
            ////    if (hero[0].x >= land[i].x && hero[0].x < land[i].x + land[i].img.Width && hero[0].y == land[i].y - 50 )
            ////    {
            ////        flagland = 1;
            ////    }
            ////}


            if (hero[0].y > 700 && hero[0].y < 800)
            {
                flagland2 = 1;

            }

            if (flagland2 == 1 || flagupland2 == 1 || flagelevator2 == 1)
            {
                return 1;

            }
            else
            {
                return -1;
            }

        }


        int checkladder()
        {
            for (int i = 0; i < ladders.Count; i++)
            {


                if (hero[0].x >= ladders[i].x - back[0].rcSrc.X - 30 && hero[0].x < (ladders[i].x + ladders[i].img.Width + 30) - back[0].rcSrc.X)
                {

                    return i;
                }
            }


            //if (hero[0].x > )
            //{

            //}

            return -1;
        }




        void checkbomb()
        {
            for (int k = 0; k < bomb.Count; k++)
            {

                if (bomb[k].flag == 1)
                {



                    if (hero[0].x >= (bomb[k].x - 50) - back[0].rcSrc.X && hero[0].x <= (bomb[k].x + bomb[k].img.Width + 50) - back[0].rcSrc.X && bomb[k].y >= hero[0].y && bomb[k].y <= hero[0].y + hero[0].img[0].Height)
                    {
                        bomb[k].flag = 0;
                        ctgameover++;
                        flagbomb = 1;
                        ctbomb = 0;
                    }


                }


                //if (bomb[k].x - back[0].rcSrc.X >= hero[0].x + hero[0].img[0].Width -10 &&
                //     bomb[k].y <= hero[0].y  &&  bomb[k].y <= hero[0].img[0].Height)
                //{

                //}
            }
        }


        void collectcoin()
        {
            for (int k = 0; k < allcoins.Count; k++)
            {

                if (allcoins[k].flag == 1)
                {



                    if (hero[0].x >= (allcoins[k].x - 50) - back[0].rcSrc.X && hero[0].x <= (allcoins[k].x + allcoins[k].img.Width + 50) - back[0].rcSrc.X && allcoins[k].y >= hero[0].y && allcoins[k].y <= hero[0].y + hero[0].img[0].Height)
                    {
                        allcoins[k].flag = 0;
                        ctmoney++;
                        flagcoin = 1;
                        ctcoin = 0;
                    }


                }


                //if (bomb[k].x - back[0].rcSrc.X >= hero[0].x + hero[0].img[0].Width -10 &&
                //     bomb[k].y <= hero[0].y  &&  bomb[k].y <= hero[0].img[0].Height)
                //{

                //}
            }
        }

        /////////////////////
        ///
        ///

        void createbomb()
        {
            cbomb pnn = new cbomb();
            pnn.x = 1450;
            pnn.img = new Bitmap("bomb.png");
            pnn.y = 390;


            bomb.Add(pnn);

            for (int k = 0; k < 3; k++)
            {


                for (int i = 0; i < 3; i++)
                {

                    if (k == 0)
                    {
                        x = r.Next(2600, 2800);

                    }


                    if (k == 1)
                    {
                        x = r.Next(5800, 6800);

                    }

                    if (k == 2)
                    {
                        x = r.Next(4800, 5800);

                    }

                    if (k == 3)
                    {
                        x = r.Next(5900, 6900);

                    }
                    int y = r.Next(400, 750);
                    pnn = new cbomb();
                    pnn.x = x;
                    pnn.y = y;
                    pnn.img = new Bitmap("bomb.png");
                    bomb.Add(pnn);

                }
            }
        }


        void createcoin()
        {
            coin pnn = new coin();
            pnn.x = 120;
            pnn.y = 40;

            for (int k = 0; k < 3; k++)
            {


                Bitmap img = new Bitmap("coin" + (k + 1) + ".png");

                pnn.img.Add(img);
            }
            Bitmap img2 = new Bitmap("coins.png");
            pnn.img.Add(img2);

            coins.Add(pnn);
        }

        void createallcoin()
        {
            allcoin pnn = new allcoin();
            pnn.x = 1400;
            pnn.y = 800 - 20;
            pnn.img = new Bitmap("coins.png");
            allcoins.Add(pnn);



            //pnn = new allcoin();
            //pnn.x = 2330;
            //pnn.y = 500;
            //pnn.img = new Bitmap("coins.png");
            //allcoins.Add(pnn);

            pnn = new allcoin();
            pnn.x = 2150;
            pnn.y = 200;
            pnn.img = new Bitmap("coins.png");
            allcoins.Add(pnn);


            pnn = new allcoin();
            pnn.x = 2300;
            pnn.y = 470;
            pnn.img = new Bitmap("coins.png");
            allcoins.Add(pnn);




            pnn = new allcoin();
            pnn.x = 3000;
            pnn.y = 200;
            pnn.img = new Bitmap("coins.png");
            allcoins.Add(pnn);



            pnn = new allcoin();
            pnn.x = 3000;
            pnn.y = 470;
            pnn.img = new Bitmap("coins.png");
            allcoins.Add(pnn);



            for (int k = 0; k < 2; k++)
            {


                for (int i = 0; i < 5; i++)
                {

                    if (k == 0)
                    {
                        x = r.Next(3500, 4845);

                    }


                    if (k == 1)
                    {
                        x = r.Next(5000, 6500);

                    }


                    int y = r.Next(100, 700);
                    pnn = new allcoin();
                    pnn.x = x;
                    pnn.y = y;
                    pnn.img = new Bitmap("coins.png");
                    allcoins.Add(pnn);

                }
            }
        }

        void createhurt()
        {
            churt pnn = new churt();
            pnn.x = 50;
            pnn.y = 50;

            for (int k = 0; k < 6; k++)
            {


                Bitmap img = new Bitmap("love" + (k + 1) + ".png");
                Color clr = img.GetPixel(0, 0);
                img.MakeTransparent(clr);
                pnn.img.Add(img);
            }
            hurt.Add(pnn);
        }

        void drawback()
        {
            cback pnn = new cback();
            pnn.frame = 1;

            pnn.img = new Bitmap("allback.jpg");
            pnn.rcSrc = new Rectangle(0, 0, pnn.img.Width / 5, pnn.img.Height);
            pnn.rcDst = new Rectangle(0, 0, this.ClientSize.Width, this.ClientSize.Height);
            back.Add(pnn);




            //true 


            //cland pnn2 = new cland();
            //pnn2.img = new Bitmap("landforgame.png");

            //pnn2.rcSrc = new Rectangle(0, back[0].img.Height - pnn.img.Height, pnn.img.Width / 5, pnn.img.Height);
            //pnn2.rcDst = new Rectangle(0, 0, this.ClientSize.Width, this.ClientSize.Height);
            //land.Add(pnn2);



            // true 


            cland pnn2 = new cland();
            pnn2.img = new Bitmap("landforgame.png");

            pnn2.rcSrc = new Rectangle(0, 0, pnn2.img.Width / 5, pnn2.img.Height);
            pnn2.rcDst = new Rectangle(0, 0, this.ClientSize.Width, this.ClientSize.Height);
            land.Add(pnn2);



        }

        void createfireanami()
        {
            fireanami pnn = new fireanami();
            pnn.x = 700;
            pnn.y = 400;
            pnn.img = new Bitmap("anamigold.png");
            pnn.frame = 0;
            fireanamis.Add(pnn);
        }

        void createstaticanami()
        {

            staticanami pnn = new staticanami();
            pnn.x = 1750;
            pnn.y = 700;
            pnn.img = new Bitmap("anami.png");
            pnn.frame = 0;

            staticanamis.Add(pnn);

             pnn = new staticanami();
            pnn.x = 3200;
            pnn.y = 700;
            pnn.img = new Bitmap("anami.png");
            pnn.frame = 0;

            staticanamis.Add(pnn);
        }




        void createbolt()
        {


            bolt pnn = new bolt();
            // pnn.img = new Bitmap("bolt.png");

            pnn.x = hero[0].x + hero[0].img[0].Width + 15;
            pnn.y = (hero[0].img[0].Height / 2) + (hero[0].y) - 16;
            pnn.frame = 0;


            for (int k = 0; k < 4; k++)
            {


                Bitmap img = new Bitmap("bolt" + (k + 1) + ".png");
                Color clr = img.GetPixel(0, 0);
                img.MakeTransparent(clr);
                pnn.img.Add(img);
            }

            bolts.Add(pnn);




        }

        void createhero()
        {


            int x = 50;
            int y = 700;

            chero pnn = new chero();

            pnn.x = x;
            pnn.y = y;
            pnn.frame = 6;
            for (int k = 0; k < 3; k++)
            {


                Bitmap img = new Bitmap("idle" + (k + 1) + ".png");
                Color clr = img.GetPixel(0, 0);
                img.MakeTransparent(clr);
                pnn.img.Add(img);
            }


            for (int k = 0; k < 3; k++)
            {

                Bitmap img = new Bitmap("turn" + (k + 1) + ".png");
                Color clr = img.GetPixel(0, 0);
                img.MakeTransparent(clr);
                pnn.img.Add(img);
            }


            for (int k = 0; k < 6; k++)
            {

                Bitmap img = new Bitmap("walk" + (k + 1) + ".png");
                Color clr = img.GetPixel(0, 0);
                img.MakeTransparent(clr);
                pnn.img.Add(img);
                hero.Add(pnn);
            }


            for (int k = 0; k < 6; k++)
            {

                Bitmap img = new Bitmap("run" + (k + 1) + ".png");
                Color clr = img.GetPixel(0, 0);
                img.MakeTransparent(clr);
                pnn.img.Add(img);

            }



            for (int k = 0; k < 4; k++)
            {

                Bitmap img = new Bitmap("hurt" + (k + 1) + ".png");
                Color clr = img.GetPixel(0, 0);
                img.MakeTransparent(clr);
                pnn.img.Add(img);

            }


            for (int k = 0; k < 4; k++)
            {

                Bitmap img = new Bitmap("jump" + (k + 1) + ".png");
                Color clr = img.GetPixel(0, 0);
                img.MakeTransparent(clr);
                pnn.img.Add(img);

            }


            for (int k = 0; k < 4; k++)
            {

                Bitmap img = new Bitmap("attack" + (k + 1) + ".png");
                Color clr = img.GetPixel(0, 0);
                img.MakeTransparent(clr);
                pnn.img.Add(img);

            }

            for (int k = 0; k < 8; k++)
            {

                Bitmap img = new Bitmap("fire" + (k + 1) + ".png");
                Color clr = img.GetPixel(0, 0);
                img.MakeTransparent(clr);
                pnn.img.Add(img);

            }

            for (int k = 0; k < 5; k++)
            {

                Bitmap img = new Bitmap("dead" + (k + 1) + ".png");
                Color clr = img.GetPixel(0, 0);
                img.MakeTransparent(clr);
                pnn.img.Add(img);

            }

            for (int k = 0; k < 6; k++)
            {

                Bitmap img = new Bitmap("walkleft" + (k + 1) + ".png");
                Color clr = img.GetPixel(0, 0);
                img.MakeTransparent(clr);
                pnn.img.Add(img);
                hero.Add(pnn);
            }

            Bitmap img2 = new Bitmap("l1.png");
            Color clr2 = img2.GetPixel(0, 0);

            pnn.img.Add(img2);


            Bitmap img3 = new Bitmap("flying.png");
            Color clr3 = img3.GetPixel(0, 0);

            pnn.img.Add(img3);


            Bitmap img4 = new Bitmap("flying1.png");
            Color clr4 = img4.GetPixel(0, 0);

            pnn.img.Add(img4);

            Bitmap img5 = new Bitmap("flying2.png");
            Color clr5 = img5.GetPixel(0, 0);

            pnn.img.Add(img3);

            for (int k = 0; k < 5; k++)
            {

                Bitmap img = new Bitmap("jumpleft" + (k + 1) + ".png");
                Color clr = img.GetPixel(0, 0);
                img.MakeTransparent(clr);
                pnn.img.Add(img);

            }

            hero.Add(pnn);


        }


        void createobstacles()
        {
            cobst pnn = new cobst();
            pnn.x = 600;
            pnn.y = 250;
            pnn.img = new Bitmap("ob1.png");
            obstacles.Add(pnn);
        }

        void createupland()
        {

            upland pnn = new upland();

            pnn.img = new Bitmap("upland1.png");

            pnn.x = 1300;
            pnn.y = 400;

            upland.Add(pnn);






            pnn = new upland();

            pnn.img = new Bitmap("upland2.png");

            pnn.x = 2200;
            pnn.y = 490;



            upland.Add(pnn);


            pnn = new upland();

            pnn.img = new Bitmap("upland2.png");

            pnn.x = 2900;
            pnn.y = 490;



            upland2.Add(pnn);


            pnn = new upland();

            pnn.img = new Bitmap("upland3.png");

            pnn.x = 2900;
            pnn.y = 220;



            upland2.Add(pnn);



        }
        void createladder()
        {
            cladder pnn = new cladder();
            pnn.img = new Bitmap("v-ladder.png");

            pnn.x = 1200;

            pnn.y = 450;

            pnn.frame = 0;
            pnn.flag = 0;



            ladders.Add(pnn);

            pnn = new cladder();
            pnn.x = 2100;

            pnn.y = 550;

            pnn.frame = 0;

            pnn.img = new Bitmap("v-ladder3.png");
            pnn.flag = 1;


            ladders.Add(pnn);


            pnn = new cladder();
            pnn.x = 2800;

            pnn.y = 550;

            pnn.frame = 0;

            pnn.img = new Bitmap("v-ladder3.png");
            pnn.flag = 1;


            ladders.Add(pnn);


            pnn = new cladder();
            pnn.x = 3050;

            pnn.y = 270;

            pnn.frame = 0;

            pnn.img = new Bitmap("v-ladder2.png");
            pnn.flag = -1;


            ladders.Add(pnn);


        }




        void createelevator()
        {
            crec pnn = new crec();
            pnn.x = 400;
            pnn.y = 800;
            pnn.h = 20;
            pnn.w = 400;

            elevator.Add(pnn);
        }

        /////////// drawing 
        void DrawDubb(Graphics g)
        {

            Graphics g2 = Graphics.FromImage(off);
            DrawScene(g2);
            g.DrawImage(off, 0, 0);
        }

        void DrawScene(Graphics g2)
        {
            g2.Clear(Color.Black);


            for (int i = 0; i < back.Count; i++)
            {
                g2.DrawImage(back[i].img, back[i].rcDst, back[i].rcSrc, GraphicsUnit.Pixel);
                // g.DrawImage(back[1].img, back[1].x-200, back[1].y);
            }



            for (int i = 0; i < land.Count; i++)
            {
                g2.DrawImage(land[i].img, land[i].rcDst, land[i].rcSrc, GraphicsUnit.Pixel);
                // g.DrawImage(back[1].img, back[1].x-200, back[1].y);
            }



            for (int i = 0; i < upland2.Count; i++)
            {
                Pen pn = new Pen(Color.Black, 5);
                // g2.DrawRectangle(pn, upland[i].x - back[0].rcSrc.X, upland[i].y - back[0].rcSrc.Y,upland[i].img.Width, upland[i].img.Height);
                g2.DrawImage(upland2[i].img, upland2[i].x - back[0].rcSrc.X, upland2[i].y - back[0].rcSrc.Y);
            }





            for (int i = 0; i < upland.Count; i++)
            {
                Pen pn = new Pen(Color.Black, 5);
                // g2.DrawRectangle(pn, upland[i].x - back[0].rcSrc.X, upland[i].y - back[0].rcSrc.Y,upland[i].img.Width, upland[i].img.Height);
                g2.DrawImage(upland[i].img, upland[i].x - back[0].rcSrc.X, upland[i].y - back[0].rcSrc.Y);
            }

            for (int i = 0; i < ladders.Count; i++)
            {

                g2.DrawImage(ladders[i].img, ladders[i].x - back[0].rcSrc.X, ladders[i].y - back[0].rcSrc.Y);
            }
            for (int i = 0; i < staticanamis.Count; i++)
            {
                if (staticanamis[i].flag == 1)
                {


                    g2.DrawImage(staticanamis[i].img, staticanamis[i].x - back[0].rcSrc.X, staticanamis[i].y - back[0].rcSrc.Y);

                }
            }

            for (int i = 0; i < bomb.Count; i++)
            {
                if (bomb[i].flag == 1)
                {


                    g2.DrawImage(bomb[i].img, bomb[i].x - back[0].rcSrc.X, bomb[i].y - back[0].rcSrc.Y);

                }
            }




            for (int i = 0; i < elevator.Count; i++)
            {

                SolidBrush brsh = new SolidBrush(Color.Orchid);
                g2.FillRectangle(brsh, elevator[i].x - back[0].rcSrc.X, elevator[i].y - back[0].rcSrc.Y, elevator[i].w, elevator[i].h);
            }


            for (int i = 0; i < bolts.Count; i++)
            {
                SolidBrush brsh = new SolidBrush(Color.Orchid);

                int k = bolts[i].frame;
                if (bolts[i].flag == 1)
                {




                    // g2.FillRectangle(brsh, bolts[i].x , bolts[i].y , 50, 50);

                    g2.DrawImage(bolts[i].img[bolts[i].frame], bolts[i].x, bolts[i].y);
                }
            }



          
            for (int i = 0; i < laser2.Count; i++)
            {
                SolidBrush brsh5 = new SolidBrush(Color.FromArgb(255, 157, 0, 222));
                Pen pn = new Pen(brsh5, 2);
                if (laser2[i].flag == 1)
                {

                    g2.FillRectangle(brsh5, laser2[i].X - back[0].rcSrc.X, laser2[i].Y - back[0].rcSrc.Y, laser2[i].W , laser2[i].H );
                }
            }


            if (flaglaser == 1)
            {
                SolidBrush brsh2 = new SolidBrush(Color.FromArgb(255, 157, 0, 222));
                Pen pn = new Pen(brsh2, 2);
                for (int i = 0; i < laser.Count; i++)
                {
                    if (laser[i].flag == 1)
                    {

                        g2.FillRectangle(brsh2, laser[i].X, laser[i].Y, laser[i].W, laser[i].H);
                    }
                }
            }
            for (int i = 0; i < hurt.Count; i++)
            {
                int j = hurt[i].frame;
                g2.DrawImage(hurt[i].img[j], hurt[i].x, hurt[i].y);
            }



            for (int i = 0; i < coins.Count; i++)
            {
                int j = coins[i].frame;
                g2.DrawImage(coins[i].img[j], coins[i].x, coins[i].y);
            }

            for (int i = 0; i < allcoins.Count; i++)
            {
                if (allcoins[i].flag == 1)
                {


                    g2.DrawImage(allcoins[i].img, allcoins[i].x - back[0].rcSrc.X, allcoins[i].y - back[0].rcSrc.Y);

                }
            }




            for (int i = 0; i < hero.Count; i++)
            {
                int j = hero[i].frame;
                g2.DrawImage(hero[i].img[j], hero[i].x, hero[i].y);
            }

            if (flagwin == 1)
            {
                for (int i = 0; i < lwin.Count; i++)
                {
                    g2.DrawImage(lwin[i].img, lwin[i].rcDst, lwin[i].rcSrc, GraphicsUnit.Pixel);
                }



            }


            if (flaggameover == 1)
            {
                for (int i = 0; i < lgameover.Count; i++)
                {
                    g2.DrawImage(lgameover[i].img, lgameover[i].rcDst, lgameover[i].rcSrc, GraphicsUnit.Pixel);
                }



            }

            // this.Text = ("" + hurt.Count);
        }

    }
}