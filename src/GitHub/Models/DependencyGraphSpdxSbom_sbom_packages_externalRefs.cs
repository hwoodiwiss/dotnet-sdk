// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Models {
    public class DependencyGraphSpdxSbom_sbom_packages_externalRefs : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The category of reference to an external resource this reference refers to.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ReferenceCategory { get; set; }
#nullable restore
#else
        public string ReferenceCategory { get; set; }
#endif
        /// <summary>A locator for the particular external resource this reference refers to.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ReferenceLocator { get; set; }
#nullable restore
#else
        public string ReferenceLocator { get; set; }
#endif
        /// <summary>The category of reference to an external resource this reference refers to.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ReferenceType { get; set; }
#nullable restore
#else
        public string ReferenceType { get; set; }
#endif
        /// <summary>
        /// Instantiates a new dependencyGraphSpdxSbom_sbom_packages_externalRefs and sets the default values.
        /// </summary>
        public DependencyGraphSpdxSbom_sbom_packages_externalRefs() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static DependencyGraphSpdxSbom_sbom_packages_externalRefs CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DependencyGraphSpdxSbom_sbom_packages_externalRefs();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"referenceCategory", n => { ReferenceCategory = n.GetStringValue(); } },
                {"referenceLocator", n => { ReferenceLocator = n.GetStringValue(); } },
                {"referenceType", n => { ReferenceType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("referenceCategory", ReferenceCategory);
            writer.WriteStringValue("referenceLocator", ReferenceLocator);
            writer.WriteStringValue("referenceType", ReferenceType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}