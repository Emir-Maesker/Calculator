using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCSCalculator
{
    class CurrencyData
    {
        public Meta meta { get; set; }
        public Data data { get; set; }

        public class Meta
        {
            public DateTime last_updated_at { get; set; }
        }

        public class Data
        {
            public ADA ADA { get; set; }
            public AED AED { get; set; }
            public AFN AFN { get; set; }
            public ALL ALL { get; set; }
            public AMD AMD { get; set; }
            public ANG ANG { get; set; }
            public AOA AOA { get; set; }
            public ARB ARB { get; set; }
            public ARS ARS { get; set; }
            public AUD AUD { get; set; }
            public AVAX AVAX { get; set; }
            public AWG AWG { get; set; }
            public AZN AZN { get; set; }
            public BAM BAM { get; set; }
            public BBD BBD { get; set; }
            public BDT BDT { get; set; }
            public BGN BGN { get; set; }
            public BHD BHD { get; set; }
            public BIF BIF { get; set; }
            public BMD BMD { get; set; }
            public BNB BNB { get; set; }
            public BND BND { get; set; }
            public BOB BOB { get; set; }
            public BRL BRL { get; set; }
            public BSD BSD { get; set; }
            public BTC BTC { get; set; }
            public BTN BTN { get; set; }
            public BWP BWP { get; set; }
            public BYN BYN { get; set; }
            public BYR BYR { get; set; }
            public BZD BZD { get; set; }
            public CAD CAD { get; set; }
            public CDF CDF { get; set; }
            public CHF CHF { get; set; }
            public CLF CLF { get; set; }
            public CLP CLP { get; set; }
            public CNY CNY { get; set; }
            public COP COP { get; set; }
            public CRC CRC { get; set; }
            public CUC CUC { get; set; }
            public CUP CUP { get; set; }
            public CVE CVE { get; set; }
            public CZK CZK { get; set; }
            public DAI DAI { get; set; }
            public DJF DJF { get; set; }
            public DKK DKK { get; set; }
            public DOP DOP { get; set; }
            public DOT DOT { get; set; }
            public DZD DZD { get; set; }
            public EGP EGP { get; set; }
            public ERN ERN { get; set; }
            public ETB ETB { get; set; }
            public ETH ETH { get; set; }
            public EUR EUR { get; set; }
            public FJD FJD { get; set; }
            public FKP FKP { get; set; }
            public GBP GBP { get; set; }
            public GEL GEL { get; set; }
            public GGP GGP { get; set; }
            public GHS GHS { get; set; }
            public GIP GIP { get; set; }
            public GMD GMD { get; set; }
            public GNF GNF { get; set; }
            public GTQ GTQ { get; set; }
            public GYD GYD { get; set; }
            public HKD HKD { get; set; }
            public HNL HNL { get; set; }
            public HRK HRK { get; set; }
            public HTG HTG { get; set; }
            public HUF HUF { get; set; }
            public IDR IDR { get; set; }
            public ILS ILS { get; set; }
            public IMP IMP { get; set; }
            public INR INR { get; set; }
            public IQD IQD { get; set; }
            public IRR IRR { get; set; }
            public ISK ISK { get; set; }
            public JEP JEP { get; set; }
            public JMD JMD { get; set; }
            public JOD JOD { get; set; }
            public JPY JPY { get; set; }
            public KES KES { get; set; }
            public KGS KGS { get; set; }
            public KHR KHR { get; set; }
            public KMF KMF { get; set; }
            public KPW KPW { get; set; }
            public KRW KRW { get; set; }
            public KWD KWD { get; set; }
            public KYD KYD { get; set; }
            public KZT KZT { get; set; }
            public LAK LAK { get; set; }
            public LBP LBP { get; set; }
            public LKR LKR { get; set; }
            public LRD LRD { get; set; }
            public LSL LSL { get; set; }
            public LTC LTC { get; set; }
            public LTL LTL { get; set; }
            public LVL LVL { get; set; }
            public LYD LYD { get; set; }
            public MAD MAD { get; set; }
            public MATIC MATIC { get; set; }
            public MDL MDL { get; set; }
            public MGA MGA { get; set; }
            public MKD MKD { get; set; }
            public MMK MMK { get; set; }
            public MNT MNT { get; set; }
            public MOP MOP { get; set; }
            public MRO MRO { get; set; }
            public MRU MRU { get; set; }
            public MUR MUR { get; set; }
            public MVR MVR { get; set; }
            public MWK MWK { get; set; }
            public MXN MXN { get; set; }
            public MYR MYR { get; set; }
            public MZN MZN { get; set; }
            public NAD NAD { get; set; }
            public NGN NGN { get; set; }
            public NIO NIO { get; set; }
            public NOK NOK { get; set; }
            public NPR NPR { get; set; }
            public NZD NZD { get; set; }
            public OMR OMR { get; set; }
            public OP OP { get; set; }
            public PAB PAB { get; set; }
            public PEN PEN { get; set; }
            public PGK PGK { get; set; }
            public PHP PHP { get; set; }
            public PKR PKR { get; set; }
            public PLN PLN { get; set; }
            public PYG PYG { get; set; }
            public QAR QAR { get; set; }
            public RON RON { get; set; }
            public RSD RSD { get; set; }
            public RUB RUB { get; set; }
            public RWF RWF { get; set; }
            public SAR SAR { get; set; }
            public SBD SBD { get; set; }
            public SCR SCR { get; set; }
            public SDG SDG { get; set; }
            public SEK SEK { get; set; }
            public SGD SGD { get; set; }
            public SHP SHP { get; set; }
            public SLL SLL { get; set; }
            public SOL SOL { get; set; }
            public SOS SOS { get; set; }
            public SRD SRD { get; set; }
            public STD STD { get; set; }
            public STN STN { get; set; }
            public SVC SVC { get; set; }
            public SYP SYP { get; set; }
            public SZL SZL { get; set; }
            public THB THB { get; set; }
            public TJS TJS { get; set; }
            public TMT TMT { get; set; }
            public TND TND { get; set; }
            public TOP TOP { get; set; }
            public TRY TRY { get; set; }
            public TTD TTD { get; set; }
            public TWD TWD { get; set; }
            public TZS TZS { get; set; }
            public UAH UAH { get; set; }
            public UGX UGX { get; set; }
            public USD USD { get; set; }
            public USDC USDC { get; set; }
            public USDT USDT { get; set; }
            public UYU UYU { get; set; }
            public UZS UZS { get; set; }
            public VEF VEF { get; set; }
            public VES VES { get; set; }
            public VND VND { get; set; }
            public VUV VUV { get; set; }
            public WST WST { get; set; }
            public XAF XAF { get; set; }
            public XAG XAG { get; set; }
            public XAU XAU { get; set; }
            public XCD XCD { get; set; }
            public XDR XDR { get; set; }
            public XOF XOF { get; set; }
            public XPD XPD { get; set; }
            public XPF XPF { get; set; }
            public XPT XPT { get; set; }
            public XRP XRP { get; set; }
            public YER YER { get; set; }
            public ZAR ZAR { get; set; }
            public ZMK ZMK { get; set; }
            public ZMW ZMW { get; set; }
            public ZWL ZWL { get; set; }
        }

        public class ADA
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class AED
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class AFN
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class ALL
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class AMD
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class ANG
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class AOA
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class ARB
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class ARS
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class AUD
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class AVAX
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class AWG
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class AZN
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class BAM
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class BBD
        {
            public string code { get; set; }
            public int value { get; set; }
        }

        public class BDT
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class BGN
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class BHD
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class BIF
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class BMD
        {
            public string code { get; set; }
            public int value { get; set; }
        }

        public class BNB
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class BND
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class BOB
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class BRL
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class BSD
        {
            public string code { get; set; }
            public int value { get; set; }
        }

        public class BTC
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class BTN
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class BWP
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class BYN
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class BYR
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class BZD
        {
            public string code { get; set; }
            public int value { get; set; }
        }

        public class CAD
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class CDF
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class CHF
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class CLF
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class CLP
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class CNY
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class COP
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class CRC
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class CUC
        {
            public string code { get; set; }
            public int value { get; set; }
        }

        public class CUP
        {
            public string code { get; set; }
            public int value { get; set; }
        }

        public class CVE
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class CZK
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class DAI
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class DJF
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class DKK
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class DOP
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class DOT
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class DZD
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class EGP
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class ERN
        {
            public string code { get; set; }
            public int value { get; set; }
        }

        public class ETB
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class ETH
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class EUR
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class FJD
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class FKP
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class GBP
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class GEL
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class GGP
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class GHS
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class GIP
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class GMD
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class GNF
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class GTQ
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class GYD
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class HKD
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class HNL
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class HRK
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class HTG
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class HUF
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class IDR
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class ILS
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class IMP
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class INR
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class IQD
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class IRR
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class ISK
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class JEP
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class JMD
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class JOD
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class JPY
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class KES
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class KGS
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class KHR
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class KMF
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class KPW
        {
            public string code { get; set; }
            public int value { get; set; }
        }

        public class KRW
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class KWD
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class KYD
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class KZT
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class LAK
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class LBP
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class LKR
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class LRD
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class LSL
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class LTC
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class LTL
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class LVL
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class LYD
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class MAD
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class MATIC
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class MDL
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class MGA
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class MKD
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class MMK
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class MNT
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class MOP
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class MRO
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class MRU
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class MUR
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class MVR
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class MWK
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class MXN
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class MYR
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class MZN
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class NAD
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class NGN
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class NIO
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class NOK
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class NPR
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class NZD
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class OMR
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class OP
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class PAB
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class PEN
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class PGK
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class PHP
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class PKR
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class PLN
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class PYG
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class QAR
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class RON
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class RSD
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class RUB
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class RWF
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class SAR
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class SBD
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class SCR
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class SDG
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class SEK
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class SGD
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class SHP
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class SLL
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class SOL
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class SOS
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class SRD
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class STD
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class STN
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class SVC
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class SYP
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class SZL
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class THB
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class TJS
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class TMT
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class TND
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class TOP
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class TRY
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class TTD
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class TWD
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class TZS
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class UAH
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class UGX
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class USD
        {
            public string code { get; set; }
            public int value { get; set; }
        }

        public class USDC
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class USDT
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class UYU
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class UZS
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class VEF
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class VES
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class VND
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class VUV
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class WST
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class XAF
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class XAG
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class XAU
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class XCD
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class XDR
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class XOF
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class XPD
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class XPF
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class XPT
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class XRP
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class YER
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class ZAR
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class ZMK
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class ZMW
        {
            public string code { get; set; }
            public float value { get; set; }
        }

        public class ZWL
        {
            public string code { get; set; }
            public float value { get; set; }
        }

    }
}
