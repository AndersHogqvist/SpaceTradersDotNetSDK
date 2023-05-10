/*
 * SpaceTraders API
 *
 * SpaceTraders is an open-universe game and learning platform that offers a set of HTTP endpoints to control a fleet of ships and explore a multiplayer universe.  The API is documented using [OpenAPI](https://github.com/SpaceTradersAPI/api-docs). You can send your first request right here in your browser to check the status of the game server.  ```json http {   \"method\": \"GET\",   \"url\": \"https://api.spacetraders.io/v2\", } ```  Unlike a traditional game, SpaceTraders does not have a first-party client or app to play the game. Instead, you can use the API to build your own client, write a script to automate your ships, or try an app built by the community.  We have a [Discord channel](https://discord.com/invite/jh6zurdWk5) where you can share your projects, ask questions, and get help from other players.   
 *
 * The version of the OpenAPI document: 2.0.0
 * Contact: joel@spacetraders.io
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
 

namespace SpaceTradersDotNetSDK.Models
{
    /// <summary>
    /// MarketTradeGood
    /// </summary>
    [DataContract]
    public partial class MarketTradeGood :  IEquatable<MarketTradeGood>, IValidatableObject
    {
        /// <summary>
        /// A rough estimate of the total supply of this good in the marketplace.
        /// </summary>
        /// <value>A rough estimate of the total supply of this good in the marketplace.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SupplyEnum
        {
            /// <summary>
            /// Enum SCARCE for value: SCARCE
            /// </summary>
            [EnumMember(Value = "SCARCE")]
            SCARCE = 1,

            /// <summary>
            /// Enum LIMITED for value: LIMITED
            /// </summary>
            [EnumMember(Value = "LIMITED")]
            LIMITED = 2,

            /// <summary>
            /// Enum MODERATE for value: MODERATE
            /// </summary>
            [EnumMember(Value = "MODERATE")]
            MODERATE = 3,

            /// <summary>
            /// Enum ABUNDANT for value: ABUNDANT
            /// </summary>
            [EnumMember(Value = "ABUNDANT")]
            ABUNDANT = 4

        }

        /// <summary>
        /// A rough estimate of the total supply of this good in the marketplace.
        /// </summary>
        /// <value>A rough estimate of the total supply of this good in the marketplace.</value>
        [DataMember(Name="supply", EmitDefaultValue=true)]
        public SupplyEnum Supply { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MarketTradeGood" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MarketTradeGood() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MarketTradeGood" /> class.
        /// </summary>
        /// <param name="symbol">The symbol of the trade good. (required).</param>
        /// <param name="tradeVolume">The typical volume flowing through the market for this type of good. The larger the trade volume, the more stable prices will be. (required).</param>
        /// <param name="supply">A rough estimate of the total supply of this good in the marketplace. (required).</param>
        /// <param name="purchasePrice">The price at which this good can be purchased from the market. (required).</param>
        /// <param name="sellPrice">The price at which this good can be sold to the market. (required).</param>
        public MarketTradeGood(string symbol = default(string), int tradeVolume = default(int), SupplyEnum supply = default(SupplyEnum), int purchasePrice = default(int), int sellPrice = default(int))
        {
            // to ensure "symbol" is required (not null)
            if (symbol == null)
            {
                throw new InvalidDataException("symbol is a required property for MarketTradeGood and cannot be null");
            }
            else
            {
                this.Symbol = symbol;
            }

            // to ensure "tradeVolume" is required (not null)
            if (tradeVolume == null)
            {
                throw new InvalidDataException("tradeVolume is a required property for MarketTradeGood and cannot be null");
            }
            else
            {
                this.TradeVolume = tradeVolume;
            }

            // to ensure "supply" is required (not null)
            if (supply == null)
            {
                throw new InvalidDataException("supply is a required property for MarketTradeGood and cannot be null");
            }
            else
            {
                this.Supply = supply;
            }

            // to ensure "purchasePrice" is required (not null)
            if (purchasePrice == null)
            {
                throw new InvalidDataException("purchasePrice is a required property for MarketTradeGood and cannot be null");
            }
            else
            {
                this.PurchasePrice = purchasePrice;
            }

            // to ensure "sellPrice" is required (not null)
            if (sellPrice == null)
            {
                throw new InvalidDataException("sellPrice is a required property for MarketTradeGood and cannot be null");
            }
            else
            {
                this.SellPrice = sellPrice;
            }

        }

        /// <summary>
        /// The symbol of the trade good.
        /// </summary>
        /// <value>The symbol of the trade good.</value>
        [DataMember(Name="symbol", EmitDefaultValue=true)]
        public string Symbol { get; set; }

        /// <summary>
        /// The typical volume flowing through the market for this type of good. The larger the trade volume, the more stable prices will be.
        /// </summary>
        /// <value>The typical volume flowing through the market for this type of good. The larger the trade volume, the more stable prices will be.</value>
        [DataMember(Name="tradeVolume", EmitDefaultValue=true)]
        public int TradeVolume { get; set; }


        /// <summary>
        /// The price at which this good can be purchased from the market.
        /// </summary>
        /// <value>The price at which this good can be purchased from the market.</value>
        [DataMember(Name="purchasePrice", EmitDefaultValue=true)]
        public int PurchasePrice { get; set; }

        /// <summary>
        /// The price at which this good can be sold to the market.
        /// </summary>
        /// <value>The price at which this good can be sold to the market.</value>
        [DataMember(Name="sellPrice", EmitDefaultValue=true)]
        public int SellPrice { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MarketTradeGood {\n");
            sb.Append("  Symbol: ").Append(Symbol).Append("\n");
            sb.Append("  TradeVolume: ").Append(TradeVolume).Append("\n");
            sb.Append("  Supply: ").Append(Supply).Append("\n");
            sb.Append("  PurchasePrice: ").Append(PurchasePrice).Append("\n");
            sb.Append("  SellPrice: ").Append(SellPrice).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as MarketTradeGood);
        }

        /// <summary>
        /// Returns true if MarketTradeGood instances are equal
        /// </summary>
        /// <param name="input">Instance of MarketTradeGood to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MarketTradeGood input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Symbol == input.Symbol ||
                    (this.Symbol != null &&
                    this.Symbol.Equals(input.Symbol))
                ) && 
                (
                    this.TradeVolume == input.TradeVolume ||
                    (this.TradeVolume != null &&
                    this.TradeVolume.Equals(input.TradeVolume))
                ) && 
                (
                    this.Supply == input.Supply ||
                    (this.Supply != null &&
                    this.Supply.Equals(input.Supply))
                ) && 
                (
                    this.PurchasePrice == input.PurchasePrice ||
                    (this.PurchasePrice != null &&
                    this.PurchasePrice.Equals(input.PurchasePrice))
                ) && 
                (
                    this.SellPrice == input.SellPrice ||
                    (this.SellPrice != null &&
                    this.SellPrice.Equals(input.SellPrice))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Symbol != null)
                    hashCode = hashCode * 59 + this.Symbol.GetHashCode();
                if (this.TradeVolume != null)
                    hashCode = hashCode * 59 + this.TradeVolume.GetHashCode();
                if (this.Supply != null)
                    hashCode = hashCode * 59 + this.Supply.GetHashCode();
                if (this.PurchasePrice != null)
                    hashCode = hashCode * 59 + this.PurchasePrice.GetHashCode();
                if (this.SellPrice != null)
                    hashCode = hashCode * 59 + this.SellPrice.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {


            // TradeVolume (int) minimum
            if(this.TradeVolume < (int)1)
            {
                yield return new ValidationResult("Invalid value for TradeVolume, must be a value greater than or equal to 1.", new [] { "TradeVolume" });
            }



            // PurchasePrice (int) minimum
            if(this.PurchasePrice < (int)0)
            {
                yield return new ValidationResult("Invalid value for PurchasePrice, must be a value greater than or equal to 0.", new [] { "PurchasePrice" });
            }



            // SellPrice (int) minimum
            if(this.SellPrice < (int)0)
            {
                yield return new ValidationResult("Invalid value for SellPrice, must be a value greater than or equal to 0.", new [] { "SellPrice" });
            }

            yield break;
        }
    }

}
