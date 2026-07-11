using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermDatabricksWorkspace
{
    [JsiiClass(nativeType: typeof(azurerm.DataAzurermDatabricksWorkspace.DataAzurermDatabricksWorkspaceCustomParametersOutputReference), fullyQualifiedName: "azurerm.dataAzurermDatabricksWorkspace.DataAzurermDatabricksWorkspaceCustomParametersOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAzurermDatabricksWorkspaceCustomParametersOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAzurermDatabricksWorkspaceCustomParametersOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermDatabricksWorkspaceCustomParametersOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermDatabricksWorkspaceCustomParametersOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "machineLearningWorkspaceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MachineLearningWorkspaceId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "natGatewayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NatGatewayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "noPublicIp", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable NoPublicIp
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "privateSubnetName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrivateSubnetName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "publicIpName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PublicIpName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "publicSubnetName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PublicSubnetName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "storageAccountName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StorageAccountName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "storageAccountSkuName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StorageAccountSkuName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "virtualNetworkId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VirtualNetworkId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "vnetAddressPrefix", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VnetAddressPrefix
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.dataAzurermDatabricksWorkspace.DataAzurermDatabricksWorkspaceCustomParameters\"}", isOptional: true)]
        public virtual azurerm.DataAzurermDatabricksWorkspace.IDataAzurermDatabricksWorkspaceCustomParameters? InternalValue
        {
            get => GetInstanceProperty<azurerm.DataAzurermDatabricksWorkspace.IDataAzurermDatabricksWorkspaceCustomParameters?>();
            set => SetInstanceProperty(value);
        }
    }
}
