using System;
using NUnit.Framework;
using AutotestsApp.Gui.Forms;
using AutotestsApp.Gui.Pages;
using AutotetsApp.Gui.Framework.Pages;
using AutotetsApp.Gui.Tests;

namespace AutotestsApp.Gui.Tests
{
    public class ValidationTest : BaseTest
    {
        LandingPage LandingPage => PageFactory.GetPage<LandingPage>();
        LoginPage LoginPage => PageFactory.GetPage<LoginPage>();
        HomePage HomePage => PageFactory.GetPage<HomePage>();
        QuotePage QuotePage => PageFactory.GetPage<QuotePage>();

        [Test]
        public void AllEmpyFieldValidation()
        {
            LandingPage.Open();

            LandingPage.SignIn();

            LoginPage.LogIn("kate.test21@gmail.com", "123456789");

            QuotePage.Open().ClickOnSelectCarrier();

            String messageH = QuotePage.HandingUnit.GetDimensionsHValidationMessage();
            String messageL = QuotePage.HandingUnit.GetDimensionsLValidationMessage();
            String messageW = QuotePage.HandingUnit.GetDimensionsWValidationMessage();

            String messageClass = QuotePage.HandingUnit.Commodity.GetClassValidationMessage();
            String totalWeight = QuotePage.HandingUnit.Commodity.GetTotalWeightValidationMessage();

            AssertsAccumulator.Accumulate(() => Assert.AreEqual(QuoteConstants.VALIDATION_MESSAGE, messageClass));

            AssertsAccumulator.Accumulate(() => Assert.AreEqual(QuoteConstants.VALIDATION_MESSAGE, totalWeight));

            AssertsAccumulator.Accumulate(() => Assert.AreEqual(QuoteConstants.VALIDATION_MESSAGE, messageH));

            AssertsAccumulator.Accumulate(() => Assert.AreEqual(QuoteConstants.VALIDATION_MESSAGE, messageL));

            AssertsAccumulator.Accumulate(() => Assert.AreEqual(QuoteConstants.VALIDATION_MESSAGE, messageW));

            AssertsAccumulator.Accumulate(() => Assert.AreEqual(QuoteConstants.ORIGINAL_VALIDATION_MESSAGE, QuotePage.GetOriginValidationMessage()));

            AssertsAccumulator.Accumulate(() => Assert.AreEqual(QuoteConstants.DESTINATION_VALIDATION_MESSAGE, QuotePage.GetDestinationValidationMessage()));
        }

        [Test]
        public void OnlyRequiredField()
        {
            LandingPage.Open();

            LandingPage.SignIn();

            LoginPage.LogIn("kate.test21@gmail.com", "123456789");

            QuotePage.Open().
                SetOriginallDropdownAddress("RT Rotisserie, 101 Oak Street, San Francisco, CA 94102, USA").
                SetDestinationAutocompleteAddress("Mizyak Test, 1202 Chalet Ln, Do Not Delete – Test Account, Pelham, AL 35124, USA");

            QuotePage.HandingUnit.SetL(QuoteConstants.DIMENSIONS_INTEGER).
                                  SetW(QuoteConstants.DIMENSIONS_INTEGER).
                                  SetH(QuoteConstants.DIMENSIONS_INTEGER);

            QuotePage.HandingUnit.Commodity.SetClass(QuoteConstants.CLASS).
                                            SetTotalWeight(QuoteConstants.TOTAL_WEIGHT);
            QuotePage.ClickOnSelectCarrier();

        }

        [Test]
        public void AllFieldsWithMoreMaxValue()
        {
            LandingPage.Open();

            LandingPage.SignIn();

            LoginPage.LogIn("kate.test21@gmail.com", "123456789");

            QuotePage.Open().
                SetOriginallDropdownAddress("RT Rotisserie, 101 Oak Street, San Francisco, CA 94102, USA").
                SetDestinationAutocompleteAddress("Mizyak Test, 1202 Chalet Ln, Do Not Delete – Test Account, Pelham, AL 35124, USA");

            QuotePage.HandingUnit.SetType("Tube").
                                  SetCount(QuoteConstants.COUNT_MAX + 1).
                                  SetL(QuoteConstants.DIMENSIONS_INTEGER_MAX).
                                  SetW(QuoteConstants.DIMENSIONS_INTEGER_MAX).
                                  SetH(QuoteConstants.DIMENSIONS_INTEGER_MAX).
                                  CheckStackable();
            QuotePage.HandingUnit.Commodity.SetNMFC(QuoteConstants.NMFC_MAX_LENGTH).
                                            SetSub(QuoteConstants.SUB_MORE_MAX_LENGTH).
                                            SetClass(QuoteConstants.CLASS).
                                            SetPieces(QuoteConstants.COUNT_MAX + 1).
                                            SetTotalWeight(QuoteConstants.TOTAL_WEIGHT_MAX + 1).
                                            CheckHazMat();

            String messageNmfcValidationMessage = QuotePage.HandingUnit.Commodity.GetNMFCValidationMessage();
            String messageSubValidationMessage = QuotePage.HandingUnit.Commodity.GetSUBValidationMessage();
            String messagePiecesValidationMessage = QuotePage.HandingUnit.Commodity.GetPiecesValidationMessage();
            String messageTotalWeightMessage = QuotePage.HandingUnit.Commodity.GetTotalWeightValidationMessage();
            String messageCountValidationMessage = QuotePage.HandingUnit.GetCountValidationMessage();

            AssertsAccumulator.Accumulate(() => Assert.AreEqual(QuoteConstants.VALIDATION_COUNT_MAX_MESSAGE, messageCountValidationMessage, "Validation message on Count field is unexpected"));

            AssertsAccumulator.Accumulate(() => Assert.AreEqual(QuoteConstants.VALIDATION_NMFC_MAX_LENGTH_MESSAGE, messageNmfcValidationMessage, "Validation message on NMFC field is unexpected"));

            AssertsAccumulator.Accumulate(() => Assert.AreEqual(QuoteConstants.VALIDATION_SUB_MAX_LENGTH_MESSAGE, messageSubValidationMessage, "Validation message on SUB field is unexpected"));

            AssertsAccumulator.Accumulate(() => Assert.AreEqual(QuoteConstants.VALIDATION_PIECES_MAX_LENGTH_MESSAGE, messagePiecesValidationMessage, "Validation message on PIECES field is unexpected"));

            AssertsAccumulator.Accumulate(() => Assert.AreEqual(QuoteConstants.VALIDATION_TOTAL_WEIGHT_MAX_MESSAGE, messageTotalWeightMessage, "Validation message on PIECES field is unexpected"));

        }

        [Test]
        public void AllFieldsWithMaxValue()
        {
            LandingPage.Open();

            LandingPage.SignIn();

            LoginPage.LogIn("kate.test21@gmail.com", "123456789");

            QuotePage.Open().
                SetOriginallDropdownAddress("RT Rotisserie, 101 Oak Street, San Francisco, CA 94102, USA").
                SetDestinationAutocompleteAddress("Mizyak Test, 1202 Chalet Ln, Do Not Delete – Test Account, Pelham, AL 35124, USA");

            QuotePage.HandingUnit.SetType("Tube").
                                  SetCount(QuoteConstants.COUNT_MAX).
                                  SetL(QuoteConstants.DIMENSIONS_INTEGER_MAX).
                                  SetW(QuoteConstants.DIMENSIONS_INTEGER_MAX).
                                  SetH(QuoteConstants.DIMENSIONS_INTEGER_MAX).
                                  CheckStackable();
            QuotePage.HandingUnit.Commodity.SetNMFC(QuoteConstants.NMFC_MAX_LENGTH).
                                            SetSub(QuoteConstants.SUB_MORE_MAX_LENGTH).
                                            SetClass(QuoteConstants.CLASS).
                                            SetPieces(QuoteConstants.COUNT_MAX).
                                            SetTotalWeight(QuoteConstants.TOTAL_WEIGHT_MAX).
                                            CheckHazMat();
            QuotePage.ClickOnSelectCarrier();
        }

        [Test]
        public void AllIntegerValue()
        {
            LandingPage.Open();

            LandingPage.SignIn();

            LoginPage.LogIn("kate.test21@gmail.com", "123456789");

            QuotePage.Open().
                SetOriginallDropdownAddress("RT Rotisserie, 101 Oak Street, San Francisco, CA 94102, USA").
                SetDestinationAutocompleteAddress("Mizyak Test, 1202 Chalet Ln, Do Not Delete – Test Account, Pelham, AL 35124, USA");

            QuotePage.HandingUnit.SetType("Tube").
                                  SetCount(QuoteConstants.FOR_INTEGER_FIELDS_STRING).
                                  SetL(QuoteConstants.DIMENSIONS_INTEGER_MAX).
                                  SetW(QuoteConstants.DIMENSIONS_INTEGER_MAX).
                                  SetH(QuoteConstants.DIMENSIONS_INTEGER_MAX).
                                  CheckStackable();
            QuotePage.HandingUnit.Commodity.SetNMFC(QuoteConstants.FOR_INTEGER_FIELDS_STRING).
                                            SetSub(QuoteConstants.FOR_INTEGER_FIELDS_STRING).
                                            SetClass(QuoteConstants.CLASS).
                                            SetPieces(QuoteConstants.FOR_INTEGER_FIELDS_STRING).
                                            SetTotalWeight(QuoteConstants.FOR_INTEGER_FIELDS_STRING).
                                            CheckHazMat();

            String messageCountValidationMessage = QuotePage.HandingUnit.GetCountValidationMessage();
            String messageNmfcValidationMessage = QuotePage.HandingUnit.Commodity.GetNMFCValidationMessage();
            String messageSubValidationMessage = QuotePage.HandingUnit.Commodity.GetSUBValidationMessage();
            String messagePiecesValidationMessage = QuotePage.HandingUnit.Commodity.GetPiecesValidationMessage();
            String messageTotalWeightMessage = QuotePage.HandingUnit.Commodity.GetTotalWeightValidationMessage();

            AssertsAccumulator.Accumulate(() => Assert.AreEqual(QuoteConstants.VALIDATION_INTEGER_MESSADE, messageCountValidationMessage, "Validation message on Count field is unexpected"));

            AssertsAccumulator.Accumulate(() => Assert.AreEqual(QuoteConstants.VALIDATION_NUMERIC_MESSADE, messageNmfcValidationMessage, "Validation message on NMFC field is unexpected"));

            AssertsAccumulator.Accumulate(() => Assert.AreEqual(QuoteConstants.VALIDATION_NUMERIC_MESSADE, messageSubValidationMessage, "Validation message on SUB field is unexpected"));

            AssertsAccumulator.Accumulate(() => Assert.AreEqual(QuoteConstants.VALIDATION_INTEGER_MESSADE, messagePiecesValidationMessage, "Validation message on PIECES field is unexpected"));

            AssertsAccumulator.Accumulate(() => Assert.AreEqual(QuoteConstants.VALIDATION_INTEGER_MESSADE, messageTotalWeightMessage, "Validation message on PIECES field is unexpected"));

            QuotePage.ClickOnSelectCarrier();
        }

        [Test]
        public void LinearFeedAndClassValidation()
        {
            LandingPage.Open();

            LandingPage.SignIn();

            LoginPage.LogIn("kate.test21@gmail.com", "123456789");

            QuotePage.Open().
                SwitchVLTLToggle().
                SetOriginallDropdownAddress("RT Rotisserie, 101 Oak Street, San Francisco, CA 94102, USA").
                SetDestinationAutocompleteAddress("Mizyak Test, 1202 Chalet Ln, Do Not Delete – Test Account, Pelham, AL 35124, USA");

            QuotePage.HandingUnit.SetL(QuoteConstants.DIMENSIONS_INTEGER).
                                  SetW(QuoteConstants.DIMENSIONS_INTEGER).
                                  SetH(QuoteConstants.DIMENSIONS_INTEGER);

            QuotePage.HandingUnit.Commodity.SetTotalWeight(QuoteConstants.TOTAL_WEIGHT);

            QuotePage.ClickOnSelectCarrier();

            String messageCountValidationMessage = QuotePage.GetLinearFieldValidationMessage();

        }

        [Test]
        public void TestForCustomerWithoutCarrier()
        {
            LandingPage.Open();

            LandingPage.SignIn();

            LoginPage.LogIn("cuswithoutcarrier@yopmail.com", "123456789");

            QuotePage.Open();
        }
    }
}
