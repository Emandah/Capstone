﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Capstone.Executive_Secratary
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        DataClasses1DataContext myctx = new DataClasses1DataContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            Panel1.Visible = false;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {


            ServiceProvider myser = new ServiceProvider();
            myser.ServiceProviderType = DropDownList1.Text;
            myser.SPFirstName = DropDownList2.Text;
            myser.SPDateOfBirth = Convert.ToDateTime(DropDownList3.SelectedValue + "/" + DropDownList4.SelectedValue + "/" + DropDownList5.SelectedValue);
            myctx.ServiceProviders.InsertOnSubmit(myser);
            myctx.SubmitChanges();

            ServiceB myserb = new ServiceB();
            myserb.ServiceName = DropDownList6.Text;
            myctx.ServiceBs.InsertOnSubmit(myserb);
            myctx.SubmitChanges();

            //var naeme= from a in myctx.driver
            //select a;
            //if naeme.count()!=0
            //{
            //var na= naeme.first(); dropdownlisy1.datasource= naeme; dropdownlist1.datatextfiel=na.firstname + " " + na.lastmane;
            //dropdownlist1.datavaluefiled= na.emplid;
            //dropdowlist1.databind();
            //}


            //var ser = from a in myctx.ServiceProviders
            //          orderby a.ServiceProviderID descending
            //          select a;

            //if (ser.Count() != 0)
            //{

            //    var se = ser.First();
            //    if (se.ServiceProviderType == " Service Provider")
            //    {
            //       ServiceProvider myser = new ServiceProvider();
            //        myser.ServiceProviderID = ser.;
            //        myctx.ServiceProviders.InsertOnSubmit(myser);
            //        myctx.SubmitChanges();
        }
            }
    }
