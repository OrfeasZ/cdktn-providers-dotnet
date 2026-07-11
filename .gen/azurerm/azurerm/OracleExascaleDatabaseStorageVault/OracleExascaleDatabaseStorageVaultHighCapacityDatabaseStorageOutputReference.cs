using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.OracleExascaleDatabaseStorageVault
{
    [JsiiClass(nativeType: typeof(azurerm.OracleExascaleDatabaseStorageVault.OracleExascaleDatabaseStorageVaultHighCapacityDatabaseStorageOutputReference), fullyQualifiedName: "azurerm.oracleExascaleDatabaseStorageVault.OracleExascaleDatabaseStorageVaultHighCapacityDatabaseStorageOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class OracleExascaleDatabaseStorageVaultHighCapacityDatabaseStorageOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public OracleExascaleDatabaseStorageVaultHighCapacityDatabaseStorageOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected OracleExascaleDatabaseStorageVaultHighCapacityDatabaseStorageOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected OracleExascaleDatabaseStorageVaultHighCapacityDatabaseStorageOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "availableSizeInGb", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AvailableSizeInGb
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "totalSizeInGbInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? TotalSizeInGbInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "totalSizeInGb", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TotalSizeInGb
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.oracleExascaleDatabaseStorageVault.OracleExascaleDatabaseStorageVaultHighCapacityDatabaseStorage\"}", isOptional: true)]
        public virtual azurerm.OracleExascaleDatabaseStorageVault.IOracleExascaleDatabaseStorageVaultHighCapacityDatabaseStorage? InternalValue
        {
            get => GetInstanceProperty<azurerm.OracleExascaleDatabaseStorageVault.IOracleExascaleDatabaseStorageVaultHighCapacityDatabaseStorage?>();
            set => SetInstanceProperty(value);
        }
    }
}
