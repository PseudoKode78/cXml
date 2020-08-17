# cXML Models for C-Sharp

The code presented in this repository has been successfully used in an eCommerce site but the author makes no claims as to its usability.

Depending on which operation you need to perform, create your document model and serialize.
Depending on your serialization method you may need to prepend the xml header and/or the cXML Document Type Definition.

Example (not valid cXml, requires )
```csharp
    var xmlHeader = "<?xml version=\"1.0\" encoding=\"UTF - 8\"?>";
    var cXmlVersion = "1.2.044";
    var cXmlDTD = $"http://xml.cXML.org/schemas/cXML/{cXmlVersion}/InvoiceDetail.dtd";
    var myTimestamp = DateTime.Now;
    var request = new InvoiceDetailRequest() {
        version = cXmlVersion,
        timestamp = myTimestamp,
        payloadID = HelperUtils.GeneratePayloadId(myTimestamp, "LocalHostName"),
        Header = new Header() {
            From = new From() {
                Credential = new[] { new Credential("FromDomain", "From") }
            },
            To = new To() {
                Credential = new[] { new Credential("ToDomain", "To") }
            },
            Sender = new Sender() {
                Credential = new[] { new Credential("SenderDomain", "Sender", "SharedSecret") },
                UserAgent = "My cXML User Agent 1.0"
            }
        },
        Request = new InvoiceDetailRequestWrapper() {
            deploymentMode = "production",
            Body = new InvoiceDetailRequestBody() {
                InvoiceDetailRequestHeader = new InvoiceDetailRequestHeader() {
                    invoiceDate = invoiceDate,
                    operation = "new",
                    purpose = "standard",
                    invoiceOrigin = "supplier",
                    invoiceID  = invoiceNumber.ToString(),
                    InvoiceDetailHeaderIndicator = new InvoiceDetailHeaderIndicator(),
                    InvoiceDetailLineIndicator = new InvoiceDetailLineIndicator() {
                        isAccountingInLine = "yes",
                        isTaxInLine = "yes"
                    },
                    InvoicePartner = invoicePartners,
                    InvoiceDetailShipping = new InvoiceDetailShipping() {
                        Contact = new[] {
                            new Contact() {
                                role = "shipFrom",
                                Name = new Name(SupplierName, "en"),
                                PostalAddress = new PostalAddress(SupplierName, ShipFromAddressStreet, ShipFromAddressCity, null, ShipFromAddressPostCode, null) {
                                    Country = new Country(GetISOCountryCode(ShipFromAddressCountry), ShipFromAddressCountry)
                                }
                            },
                            new Contact() {
                                role = "shipTo",
                                Name = new Name(shipTo, "en"),
                                PostalAddress = new PostalAddress(shipName, shipAddressStreet, shipCity, null, shipPostCode, null) {
                                    Country = new Country(GetISOCountryCode(shipCountry), shipCountry)
                                }
                            }
                        }
                    },
                    PaymentTerm = new PaymentTerm() { payInNumberOfDays = PaymentNumberOfDays },
                    Extrinsic = extrinsics.Any() ? extrinsics.ToArray() : null,
                    Comments = new[] {
                        new Comments() { }
                    }
                },
                InvoiceDetailOrder = new InvoiceDetailOrder() {
                    InvoiceDetailOrderInfo = new InvoiceDetailOrderInfo() {
                        MasterAgreementReference = new MasterAgreementReference() {
                            DocumentReference = new DocumentReference() {
                                payloadID = orderPayloadId
                            },
                        },
                        OrderReference = new OrderReference() {
                            DocumentReference = new DocumentReference() {
                                payloadID = orderPayloadId
                            },
                        },
                        SupplierOrderInfo = new SupplierOrderInfo() {
                            orderID = orderNumber.ToString()
                        }
                    },
                    InvoiceDetailItem = lineItems.ToArray()
                },
                InvoiceDetailSummary = new InvoiceDetailSummary() {
                    SubtotalAmount = new SubtotalAmount() {
                        Money = new Money(currencycode, Math.Abs(subtotal))
                    },
                    Tax = new Tax() {
                        Money = new Money(currencycode, Math.Abs(vatAmount)) { alternateAmount = Math.Abs(vatAmount), alternateCurrency = currencycode },
                        Description = new Description("Total Tax", "en"),
                        TaxDetail = new TaxDetail() {
                            purpose = "tax",
                            category = "Standard Rate",
                            percentageRate = TaxPercentage,
                            TaxableAmount = new TaxableAmount() {
                                Money = new Money(currencycode, Math.Abs(netAmount))
                            },
                            TaxAmount = new TaxAmount() {
                                Money = new Money(currencycode, Math.Abs(vatAmount))
                            }
                        }
                    },
                    GrossAmount = isCreditNote ? null : new GrossAmount() {
                        Money = new Money(currencycode, Math.Abs(grossAmount))
                    },
                    NetAmount = new NetAmount() {
                        Money = new Money(currencycode, Math.Abs(netAmount))
                    },
                    DueAmount = isCreditNote ? null : new DueAmount() {
                        Money = new Money(currencycode, Math.Abs(dueAmount))
                    }
                }
            }
        }
    };

    result = SerializeHelper.SerializeString<InvoiceDetailRequest>(ref request, out success, xmlHeader, cXmlDTD);
```

Note:
If you receive an error that the endpoint is not available, you may need to run Visual Studio as Administrator.