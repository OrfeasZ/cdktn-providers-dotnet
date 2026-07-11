using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermManagedDevopsPool
{
    [JsiiClass(nativeType: typeof(azurerm.DataAzurermManagedDevopsPool.DataAzurermManagedDevopsPoolVirtualMachineScaleSetFabricOutputReference), fullyQualifiedName: "azurerm.dataAzurermManagedDevopsPool.DataAzurermManagedDevopsPoolVirtualMachineScaleSetFabricOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAzurermManagedDevopsPoolVirtualMachineScaleSetFabricOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAzurermManagedDevopsPoolVirtualMachineScaleSetFabricOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataAzurermManagedDevopsPoolVirtualMachineScaleSetFabricOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermManagedDevopsPoolVirtualMachineScaleSetFabricOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "image", typeJson: "{\"fqn\":\"azurerm.dataAzurermManagedDevopsPool.DataAzurermManagedDevopsPoolVirtualMachineScaleSetFabricImageList\"}")]
        public virtual azurerm.DataAzurermManagedDevopsPool.DataAzurermManagedDevopsPoolVirtualMachineScaleSetFabricImageList Image
        {
            get => GetInstanceProperty<azurerm.DataAzurermManagedDevopsPool.DataAzurermManagedDevopsPoolVirtualMachineScaleSetFabricImageList>()!;
        }

        [JsiiProperty(name: "osDiskStorageAccountType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OsDiskStorageAccountType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "security", typeJson: "{\"fqn\":\"azurerm.dataAzurermManagedDevopsPool.DataAzurermManagedDevopsPoolVirtualMachineScaleSetFabricSecurityList\"}")]
        public virtual azurerm.DataAzurermManagedDevopsPool.DataAzurermManagedDevopsPoolVirtualMachineScaleSetFabricSecurityList Security
        {
            get => GetInstanceProperty<azurerm.DataAzurermManagedDevopsPool.DataAzurermManagedDevopsPoolVirtualMachineScaleSetFabricSecurityList>()!;
        }

        [JsiiProperty(name: "skuName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SkuName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "storage", typeJson: "{\"fqn\":\"azurerm.dataAzurermManagedDevopsPool.DataAzurermManagedDevopsPoolVirtualMachineScaleSetFabricStorageList\"}")]
        public virtual azurerm.DataAzurermManagedDevopsPool.DataAzurermManagedDevopsPoolVirtualMachineScaleSetFabricStorageList Storage
        {
            get => GetInstanceProperty<azurerm.DataAzurermManagedDevopsPool.DataAzurermManagedDevopsPoolVirtualMachineScaleSetFabricStorageList>()!;
        }

        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubnetId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.dataAzurermManagedDevopsPool.DataAzurermManagedDevopsPoolVirtualMachineScaleSetFabric\"}", isOptional: true)]
        public virtual azurerm.DataAzurermManagedDevopsPool.IDataAzurermManagedDevopsPoolVirtualMachineScaleSetFabric? InternalValue
        {
            get => GetInstanceProperty<azurerm.DataAzurermManagedDevopsPool.IDataAzurermManagedDevopsPoolVirtualMachineScaleSetFabric?>();
            set => SetInstanceProperty(value);
        }
    }
}
