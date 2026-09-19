# Product Spec: Chemist Shop Management System

## Product Name Suggestion: **"MediDukan"** or **"PharmEasy Manager"**

---

## The Opportunity

- **8.5 lakh+ registered chemist shops** in India (AIOCD data)
- 70%+ still use manual registers or outdated DOS-based software
- Government is pushing digitization (e-pharmacy regulations, drug track & trace)
- **Drug License renewal, Schedule H/H1 tracking, expiry management** are massive pain points
- Existing solutions (Marg ERP, Retailgraph) are expensive and complex
- A modern, mobile-friendly, affordable solution wins this market

---

## Core Features

### Module 1: Smart Billing & POS
- Fast medicine billing with barcode scanner support
- Auto-suggest medicine names (fuzzy search across 50,000+ medicines)
- Batch number and expiry date tracking on every sale
- GST-compliant invoices (5%, 12%, 18% categories auto-applied)
- UPI/card payment integration
- Print receipt on thermal printer / share on WhatsApp
- Customer purchase history
- Credit/udhar management (critical for Indian chemists)

### Module 2: Inventory Management
- Real-time stock tracking
- **Auto-reorder alerts** when stock falls below minimum level
- Expiry date tracking with alerts (30/60/90 days before expiry)
- Near-expiry return management (to distributor)
- Dead stock identification
- Batch-wise inventory
- Rack/shelf location mapping
- Multiple store support

### Module 3: Drug License & Compliance
- Drug license renewal reminders
- **Schedule H drug register** (auto-maintained digitally)
- **Schedule H1 drug register** (mandatory record keeping)
- Narcotic drug register
- Sales register as per Drugs & Cosmetics Act
- Purchase register
- Temperature log for cold storage medicines
- Audit-ready reports for Drug Inspector visits
- Digital signature support

### Module 4: Purchase & Distributor Management
- Distributor/stockist database
- Purchase order creation
- Purchase invoice entry with auto-stock update
- Price comparison across distributors
- Payment tracking & dues
- Return/damage note management
- Scheme & offer tracking from companies

### Module 5: GST & Accounting
- Auto GST calculation (medicine-wise tax rates)
- GSTR-1 and GSTR-3B report generation
- Profit & loss per medicine / per category
- Daily/weekly/monthly sales reports
- Cash flow tracking
- Integration with Tally (export)
- TDS tracking for high-value purchases

### Module 6: Customer Management (CRM)
- Customer database with mobile number
- Prescription upload and storage
- Refill reminders via WhatsApp/SMS
- Loyalty points system
- OTC product recommendations
- Chronic patient medicine tracking (diabetes, BP, thyroid)

### Module 7: AI-Powered Features (Your Differentiator)
- **Drug interaction checker** - Alert when conflicting medicines are sold together
- **Demand forecasting** - Predict which medicines will sell more (seasonal patterns)
- **Smart pricing** - Suggest competitive pricing based on locality
- **Voice-based billing** - Speak medicine name in Hindi, system finds it (game changer for busy shops)
- **Photo prescription reader** - Customer shows prescription photo, AI reads medicine names

---

## Why This Beats Existing Solutions

| Existing (Marg, Busy, Retailgraph) | MediDukan |
|---|---|
| Desktop only | Web + Mobile (works on phone/tablet) |
| 15,000-50,000 INR one-time + annual renewal | 499-1499 INR/month subscription |
| Complex setup, needs technician | Self-setup in 15 minutes |
| No WhatsApp integration | WhatsApp billing, reminders, reports |
| No AI features | Drug interaction, demand forecasting, voice billing |
| Hindi support poor | Full Hindi + regional language UI |
| No cloud backup | Auto cloud backup, access from anywhere |
| No mobile app | Android app for on-the-go |
| Training needed | So simple any shop assistant can use it |
| Outdated interface | Modern, clean, fast UI |

---

## Target Market

### Primary: Independent Chemist Shops
- 7+ lakh shops across India
- Owner-operated, 1-5 staff
- Price sensitive, need simplicity
- Decision maker: shop owner (usually pharmacist)

### Secondary: Chain Pharmacies (2-20 outlets)
- Growing segment in tier-2/3 cities
- Need multi-store management
- Centralized inventory and reporting

### Tertiary: Hospital Pharmacies
- In-patient and out-patient dispensing
- Integration with hospital management systems
- Higher price tolerance

### Geography Strategy
- **Start:** Bhadohi, Varanasi, Mirzapur, Jaunpur (your local market)
- **Expand:** Entire UP (highest number of chemist shops in India)
- **Then:** Bihar, MP, Rajasthan (Hindi belt - language advantage)
- **National:** All India

---

## Revenue Model

| Plan | Price (INR/month) | For |
|---|---|---|
| **Basic** | 499 | Single counter, up to 5000 products |
| **Standard** | 999 | Multi-counter, unlimited products, WhatsApp |
| **Premium** | 1,499 | + AI features, multi-store, API access |
| **Enterprise** | 4,999 | Hospital pharmacy, custom integrations |

### Additional Revenue Streams
| Source | Revenue |
|---|---|
| SMS/WhatsApp credits | 0.25-0.50 INR per message |
| Hardware (barcode scanner, printer) reselling | 15-25% margin |
| Medicine data/analytics to pharma companies (anonymized) | B2B licensing |
| Distributor listing/advertising | Monthly fee from distributors |
| Payment gateway commission | 0.1-0.3% per transaction |

### Revenue Projections

| Milestone | Shops | Monthly Revenue |
|---|---|---|
| 6 months | 100 shops | 75,000-1,00,000 INR |
| 12 months | 500 shops | 4,00,000-6,00,000 INR |
| 24 months | 2,000 shops | 15,00,000-25,00,000 INR |
| 36 months | 10,000 shops | 75,00,000-1,00,00,000 INR |

---

## Go-to-Market Strategy

### Phase 1: Local (Bhadohi + Nearby)
1. Visit 20 chemist shops in Bhadohi personally
2. Offer FREE 3-month trial to first 50 shops
3. Get feedback, iterate
4. Get testimonials and case studies
5. Approach Bhadohi Chemist Association

### Phase 2: Regional (UP)
1. Partner with medicine distributors (they visit every shop)
2. Attend pharma trade shows (AIOCD events)
3. Chemist association partnerships
4. YouTube demos in Hindi
5. Instagram ads targeting pharmacy owners

### Phase 3: National
1. Digital marketing (Google Ads: "chemist shop software")
2. Referral program (existing users refer new shops for 1 month free)
3. Channel partners in each state
4. Integration with major distributors
5. App store presence (Google Play)

---

## MVP Scope (Build in 10-14 Weeks)

### Phase 1 MVP - Ship This
1. Medicine master database (50,000+ medicines pre-loaded)
2. Fast billing with medicine search
3. Inventory with stock tracking
4. Expiry date alerts
5. Basic GST invoice
6. Daily sales report
7. Customer database
8. WhatsApp bill sharing
9. Cloud backup
10. Mobile responsive (works on tablet)

### Phase 2 (Month 3-5)
- Schedule H/H1 register
- Purchase management
- Distributor module
- Barcode scanner integration
- SMS/WhatsApp reminders
- Android app

### Phase 3 (Month 5-8)
- AI drug interaction checker
- Demand forecasting
- Voice billing
- Multi-store support
- Tally export
- GSTR reports

---

## Medicine Database Source

| Source | Data Available | Access |
|---|---|---|
| **1mg API** (if available) | Medicine names, compositions, prices | Check API access |
| **Open FDA India** | Drug formulations database | Free |
| **CDSCO website** | Approved drugs list | Public data, scrape-able |
| **Indian Pharmacopoeia** | Standard drug names | Reference |
| **DPCO price list** | Ceiling prices for essential medicines | Government published |
| Build your own | Start with top 5000 medicines, grow with usage | Manual + community |

---

## Regulatory Compliance

### What Your Software Must Handle
1. **Drugs & Cosmetics Act, 1940** - Sale records, Schedule H/H1
2. **GST Act** - Proper tax invoicing
3. **Pharmacy Act** - Drug license display
4. **NDPS Act** - Narcotic drug record keeping
5. **Consumer Protection Act** - Bill/receipt for every sale

### What You Need as Software Seller
- No special license to sell pharmacy software
- Standard GST registration
- Data privacy compliance (don't store patient health data without consent)
- Terms of service clearly stating you're software, not medical advice
