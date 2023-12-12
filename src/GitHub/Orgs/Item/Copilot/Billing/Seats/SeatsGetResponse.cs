// <auto-generated/>
using GitHub.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Orgs.Item.Copilot.Billing.Seats {
    public class SeatsGetResponse : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The seats property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<CopilotSeatDetails>? Seats { get; set; }
#nullable restore
#else
        public List<CopilotSeatDetails> Seats { get; set; }
#endif
        /// <summary>Total number of Copilot For Business seats for the organization currently being billed.</summary>
        public int? TotalSeats { get; set; }
        /// <summary>
        /// Instantiates a new seatsGetResponse and sets the default values.
        /// </summary>
        public SeatsGetResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static SeatsGetResponse CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SeatsGetResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"seats", n => { Seats = n.GetCollectionOfObjectValues<CopilotSeatDetails>(CopilotSeatDetails.CreateFromDiscriminatorValue)?.ToList(); } },
                {"total_seats", n => { TotalSeats = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<CopilotSeatDetails>("seats", Seats);
            writer.WriteIntValue("total_seats", TotalSeats);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}