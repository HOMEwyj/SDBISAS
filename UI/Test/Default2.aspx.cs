﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

public partial class Test_Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (Class1.isLoing(TextBox1.Text, TextBox2.Text))
        {
            Label1.Text = "登陆成功";
        }
        else
        {
            Label1.Text = "登陆失败";
        }
        
    }
}