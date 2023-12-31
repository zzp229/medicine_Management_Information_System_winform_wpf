﻿using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 医药管理系统wpf.Models;

using System.Windows;
using 医药管理系统wpf.ViewModels.Manager;
using GalaSoft.MvvmLight.Command;
using 医药管理系统wpf.Views.Helper;

using GalaSoft.MvvmLight.Messaging; //给Messager使用

namespace 医药管理系统wpf.ViewModels.UserViewsModelView
{
    internal class MedicineViewModel:ViewModelBase
    {
        /// <summary>
        /// 重载
        /// </summary>
        /// <param name="medicine"></param>
        /// <param name="isEdit">判断是否编辑</param>
        public MedicineViewModel(Medicine medicine, bool isEdit)
        {
            //初始化ComboBox
            MmodeList = new List<string>
            {
                "内服",
                "外用"
            };
            this.medicine = medicine;
            this.mmode = medicine.Mmode;

            //这里还要设置关闭窗口的command，确认按钮用
            CloseWindowCommand = new RelayCommand<object>(t => CloseWindow(t)); //xaml会将窗口Window传进来

            Mmode = medicine.Mmode; //先选择
            this.IsEdit = isEdit;
        }

        #region 属性
        private string mmode;
        /// <summary>
        /// 服用方法
        /// </summary>
        public string Mmode
        {
            get { return mmode; }
            set { mmode = value; RaisePropertyChanged(); }
        }

        private List<string> mmodeList;
        /// <summary>
        /// 服用方法列表
        /// </summary>
        public List<string> MmodeList
        {
            get { return mmodeList; }
            set { mmodeList = value; RaisePropertyChanged(); }
        }

        private Medicine _medicine;
        /// <summary>
        /// 药品实体类
        /// </summary>
        public Medicine medicine
        {
            get { return _medicine; }
            set { _medicine = value; RaisePropertyChanged(); }
        }

        private bool isEdit;
        /// <summary>
        /// 判断是修改还是增加
        /// </summary>
        public bool IsEdit
        {
            get { return isEdit; }
            set { isEdit = value; RaisePropertyChanged(); }
        }
        #endregion


        #region Command
        public RelayCommand<object> CloseWindowCommand { get; set; }
        #endregion


        #region Method

        private void CloseWindow(object parameter)
        {
            var window = parameter as Window;
            if (window != null)
            {
                //根据IsEdit判断是添加还是修改
                if(!IsEdit) //这个好像是修改的
                {
                    //更新一下选中的服用方法
                    medicine.Mmode = Mmode;
                    int a = MedicineManager.UpdateMedicineByMno(medicine);
                    if(a > 0)
                    {
                        MessageBox.Show("修改成功！");
                    }

                }
                else
                {
                    //更新一下选中的服用方法
                    medicine.Mmode = Mmode;
                    //往数据库增加
                    int a = MedicineManager.InsertMedicine(medicine);
                    if (a > 0)
                        MessageBox.Show("添加成功！");
                }

                //更新状态，状态在CloseWindowMessage类中
                var message = new CloseWindowMessage
                {
                    MedicineView_DialogResult = true
                };
                Messenger.Default.Send(message);

                //关闭窗口，然后到FrmView_Medicine中更新一下数据
                window.Close();
            }
        }

        #endregion
    }
}
