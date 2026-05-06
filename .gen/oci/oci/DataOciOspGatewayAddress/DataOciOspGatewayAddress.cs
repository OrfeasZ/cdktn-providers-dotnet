using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciOspGatewayAddress
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/osp_gateway_address oci_osp_gateway_address}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciOspGatewayAddress.DataOciOspGatewayAddress), fullyQualifiedName: "oci.dataOciOspGatewayAddress.DataOciOspGatewayAddress", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciOspGatewayAddress.DataOciOspGatewayAddressConfig\"}}]")]
    public class DataOciOspGatewayAddress : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/osp_gateway_address oci_osp_gateway_address} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciOspGatewayAddress(Constructs.Construct scope, string id, oci.DataOciOspGatewayAddress.IDataOciOspGatewayAddressConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciOspGatewayAddress.IDataOciOspGatewayAddressConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciOspGatewayAddress(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciOspGatewayAddress(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciOspGatewayAddress resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciOspGatewayAddress to import.</param>
        /// <param name="importFromId">The id of the existing DataOciOspGatewayAddress that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciOspGatewayAddress to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciOspGatewayAddress to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/osp_gateway_address#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciOspGatewayAddress that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciOspGatewayAddress to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciOspGatewayAddress.DataOciOspGatewayAddress), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiMethod(name: "synthesizeHclAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeHclAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(oci.DataOciOspGatewayAddress.DataOciOspGatewayAddress))!;

        [JsiiProperty(name: "addressKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AddressKey
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "city", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string City
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "companyName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompanyName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "contributorClass", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ContributorClass
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "country", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Country
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "county", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string County
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "departmentName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DepartmentName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "emailAddress", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EmailAddress
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "firstName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FirstName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "internalNumber", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InternalNumber
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "jobTitle", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string JobTitle
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lastName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LastName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "line1", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Line1
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "line2", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Line2
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "line3", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Line3
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "line4", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Line4
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "middleName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MiddleName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "municipalInscription", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MunicipalInscription
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "phoneCountryCode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PhoneCountryCode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "phoneNumber", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PhoneNumber
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "postalCode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PostalCode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "province", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Province
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "stateInscription", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StateInscription
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "streetName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StreetName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "streetNumber", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StreetNumber
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "addressIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AddressIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "compartmentIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CompartmentIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ospHomeRegionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OspHomeRegionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "addressId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AddressId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ospHomeRegion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OspHomeRegion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
