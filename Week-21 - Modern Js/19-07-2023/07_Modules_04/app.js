// import { rastgeleSayilar, tekSayilar, ciftSayilar } from "./tek_cift.js";
import * as tekCift from "./tek_cift";

let rastgeleSayiDizisi = tekCift.rastgeleSayilar();
console.log(rastgeleSayiDizisi);
console.log(tekCift.tekSayilar(rastgeleSayiDizisi));
console.log(tekCift.ciftSayilar(rastgeleSayiDizisi));
