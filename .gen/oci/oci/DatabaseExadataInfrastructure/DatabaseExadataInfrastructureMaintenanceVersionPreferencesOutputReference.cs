using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseExadataInfrastructure
{
    [JsiiClass(nativeType: typeof(oci.DatabaseExadataInfrastructure.DatabaseExadataInfrastructureMaintenanceVersionPreferencesOutputReference), fullyQualifiedName: "oci.databaseExadataInfrastructure.DatabaseExadataInfrastructureMaintenanceVersionPreferencesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DatabaseExadataInfrastructureMaintenanceVersionPreferencesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DatabaseExadataInfrastructureMaintenanceVersionPreferencesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DatabaseExadataInfrastructureMaintenanceVersionPreferencesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatabaseExadataInfrastructureMaintenanceVersionPreferencesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetReferenceResourceIdForImageUpdates")]
        public virtual void ResetReferenceResourceIdForImageUpdates()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "referenceResourceIdForImageUpdatesInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ReferenceResourceIdForImageUpdatesInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "referenceResourceIdForImageUpdates", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ReferenceResourceIdForImageUpdates
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.databaseExadataInfrastructure.DatabaseExadataInfrastructureMaintenanceVersionPreferences\"}", isOptional: true)]
        public virtual oci.DatabaseExadataInfrastructure.IDatabaseExadataInfrastructureMaintenanceVersionPreferences? InternalValue
        {
            get => GetInstanceProperty<oci.DatabaseExadataInfrastructure.IDatabaseExadataInfrastructureMaintenanceVersionPreferences?>();
            set => SetInstanceProperty(value);
        }
    }
}
