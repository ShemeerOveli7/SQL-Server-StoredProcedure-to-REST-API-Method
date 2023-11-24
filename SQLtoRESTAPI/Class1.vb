Public void toSave()
    {
      Try
      {
        If (this.isMandatoryFieldsCompleted())
        {
          this.뵅();
          If (this.봭)
          {
            int infoMessage = (Int()) MessageBox.toInfoMessage(봭.봯.볥);
            ((Control) this.봃()).Focus();
          }
          Else
          {
            If (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.mstrType, FC7480ED \ u002D2AF5 \ u002D4C25 \ u002DAD61 \ u002D5FBADDF92FCC.봫봲(), False) == 0)
            {
              If (MessageBox.toYesNo(FC7480ED \ u002D2AF5 \ u002D4C25 \ u002DAD61 \ u002D5FBADDF92FCC.봅볶()) == DialogResult.No)
Return;
            }
            ElseIf (MessageBox.toYesNo(봭.봯.볯) == DialogResult.No)
Return;
            Double num;
            String str;
            If (this.봹().SelectedIndex == 1)
            {
              num = Conversions.ToDouble(FC7480ED \ u002D2AF5 \ u002D4C25 \ u002DAD61 \ u002D5FBADDF92FCC.뵍봉() + ((RadTextBoxBase) this.봗()).Text);
              str = FC7480ED \ u002D2AF5 \ u002D4C25 \ u002DAD61 \ u002D5FBADDF92FCC.봫뵖();
            }
            Else
            {
              num = Conversions.ToDouble(FC7480ED \ u002D2AF5 \ u002D4C25 \ u002DAD61 \ u002D5FBADDF92FCC.뵍봉() + ((RadTextBoxBase) this.뵌()).Text);
              str = FC7480ED \ u002D2AF5 \ u002D4C25 \ u002DAD61 \ u002D5FBADDF92FCC.봫봁();
            }
            clsPurchaseBL 봭1 = this.봭;
            Object selectedValue1 = this.볺().SelectedValue;
            Guid uiSupplierID = selectedValue1!= null?(Guid) selectedValue1 : New Guid();
            int 봦1 = 봭.봯.봦;
            String text = this.볺().Text;
            DateTime dateTime = this.봣().Value;
            DateTime date1 = dateTime.Date;
            dateTime = this.봃().Value;
            DateTime date2 = dateTime.Date;
            Decimal mnTotalAmount = Conversions.ToDecimal(FC7480ED \ u002D2AF5 \ u002D4C25 \ u002DAD61 \ u002D5FBADDF92FCC.뵍봉() + ((RadControl) this.볧()).Text.Trim());
            Decimal mnTaxAmount = Conversions.ToDecimal(FC7480ED \ u002D2AF5 \ u002D4C25 \ u002DAD61 \ u002D5FBADDF92FCC.뵍봉() + ((RadControl) this.뵝()).Text);
            String vaPurchaseInvoiceStatus = FC7480ED \ u002D2AF5 \ u002D4C25 \ u002DAD61 \ u002D5FBADDF92FCC.뵍봙();
            Decimal mnDiscount = New Decimal(num);
            String vaGSTIN = ((RadTextBoxBase) this.뵇()).Text.Trim();
            String vaPurchaseOrderNo = ((RadTextBoxBase) this.봻()).Text.Trim() ?? FC7480ED\u002D2AF5\u002D4C25\u002DAD61\u002D5FBADDF92FCC.봦봬();
            dateTime = this.봁().Value;
            DateTime date3 = dateTime.Date;
            int 봭2 = 봭.봯.봭;
            Guid 봭3 = 봭.봯.봭;
            String vaVoucherName = FC7480ED \ u002D2AF5 \ u002D4C25 \ u002DAD61 \ u002D5FBADDF92FCC.봫볿();
            Object selectedValue2 = this.뵓().SelectedValue;
            Guid uiPaymentTermID = selectedValue2!= null?(Guid) selectedValue2 : New Guid();
            DataTable 봦2 = this.봦;
            String 봭4 = this.봭;
            String vaCommonNarration = ((RadTextBoxBase) this.볯()).Text.Trim();
            Guid 뵑 = 봭.봯.뵑;
            Guid 봦3 = 봭.봯.봦;
            Guid 볺1 = 봭.봯.볺;
            String vaStatus = FC7480ED \ u002D2AF5 \ u002D4C25 \ u002DAD61 \ u002D5FBADDF92FCC.볩뵁();
            Decimal 봭5 = this.봭;
            String 봦4 = this.봦;
            String vaInvoiceNo = ((RadTextBoxBase) this.볩()).Text.Trim();
            String 볺2 = this.볺;
            String 봯 = this.봯;
            Object selectedValue3 = this.보().SelectedValue;
            Guid uiTDSMasterID = selectedValue3!= null?(Guid) selectedValue3 : New Guid();
            Double mnTDSAmount = Conversions.ToDouble(FC7480ED \ u002D2AF5 \ u002D4C25 \ u002DAD61 \ u002D5FBADDF92FCC.뵍봉() + ((RadTextBoxBase) this.봳()).Text);
            String vaTaxInclusive = Conversions.ToString(Interaction.IIf(this.봝().SelectedIndex == 0, (Object) FC7480ED\u002D2AF5\u002D4C25\u002DAD61\u002D5FBADDF92FCC.뵑볰(), (Object) FC7480ED\u002D2AF5\u002D4C25\u002DAD61\u002D5FBADDF92FCC.뵑봓()));
            Double mnRoundOff = Conversion.Val(((RadTextBoxBase) this.봬()).Text);
            Guid muiPurchaseOrderId = this.muiPurchaseOrderID;
            Double mnSubTotal = Conversions.ToDouble(FC7480ED \ u002D2AF5 \ u002D4C25 \ u002DAD61 \ u002D5FBADDF92FCC.뵍봉() + ((RadControl) this.뵒()).Text);
            Double mnAmountBeforeTax = Conversions.ToDouble(FC7480ED \ u002D2AF5 \ u002D4C25 \ u002DAD61 \ u002D5FBADDF92FCC.뵍봉() + ((RadControl) this.봪()).Text);
            Double mnCessAmount = Conversions.ToDouble(FC7480ED \ u002D2AF5 \ u002D4C25 \ u002DAD61 \ u002D5FBADDF92FCC.뵍봉() + ((RadControl) this.볻()).Text);
            Double mnTaxableAmount = Conversions.ToDouble(FC7480ED \ u002D2AF5 \ u002D4C25 \ u002DAD61 \ u002D5FBADDF92FCC.뵍봉() + ((RadControl) this.봪()).Text);
            String vaDiscountPreference = str;
            Double mnCustomsDuty = Conversions.ToDouble(FC7480ED \ u002D2AF5 \ u002D4C25 \ u002DAD61 \ u002D5FBADDF92FCC.뵍봉() + ((RadTextBoxBase) this.뵄()).Text);
            Guid purchaseInvoiceMemoId = this.muiPurchaseInvoiceMemoID;
            DataTable dataTable = 봭1.InsertPurchaseInvoice(uiSupplierID, 봦1, Text, date1, date2, mnTotalAmount, mnTaxAmount, vaPurchaseInvoiceStatus, mnDiscount, vaGSTIN, vaPurchaseOrderNo, date3, 봭2, 봭3, vaVoucherName, uiPaymentTermID, 봦2, 봭4, vaCommonNarration, 뵑, 봦3, 볺1, vaStatus, 봭5, 봦4, vaInvoiceNo, 0M, 볺2, 봯, uiTDSMasterID, mnTDSAmount, vaTaxInclusive, mnRoundOff, muiPurchaseOrderId, mnSubTotal, mnAmountBeforeTax, mnCessAmount, mnTaxableAmount, vaDiscountPreference, mnCustomsDuty, purchaseInvoiceMemoId);
            If (dataTable.Rows.Count > 0)
            {
              this.muiPurchaseInvoiceID = Guid.Parse(dataTable.Rows[0][FC7480ED\u002D2AF5\u002D4C25\u002DAD61\u002D5FBADDF92FCC.봓봏()].ToString());
              int savedSuccessfully = (Int()) MessageBox.toSavedSuccessfully();
              ((Form) 봭.뵑.볺.봄()).Close();
              봭.뵑.볺.봄().muiPurchaseInvoiceID = this.muiPurchaseInvoiceID;
              봭.뵑.볺.봄().mstrType = FC7480ED \ u002D2AF5 \ u002D4C25 \ u002DAD61 \ u002D5FBADDF92FCC.봫볿();
              this.봭.fnShowForm((Form) 봭.뵑.볺.봄());
              this.toClear();
            }
          }
        }
      }
      Catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Throw ex;
      }
    }
