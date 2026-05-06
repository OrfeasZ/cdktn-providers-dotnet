using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseDbSystem
{
    [JsiiClass(nativeType: typeof(oci.DatabaseDbSystem.DatabaseDbSystemDbSystemOptionsOutputReference), fullyQualifiedName: "oci.databaseDbSystem.DatabaseDbSystemDbSystemOptionsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DatabaseDbSystemDbSystemOptionsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DatabaseDbSystemDbSystemOptionsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DatabaseDbSystemDbSystemOptionsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatabaseDbSystemDbSystemOptionsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetStorageManagement")]
        public virtual void ResetStorageManagement()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "storageManagementInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StorageManagementInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "storageManagement", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StorageManagement
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.databaseDbSystem.DatabaseDbSystemDbSystemOptions\"}", isOptional: true)]
        public virtual oci.DatabaseDbSystem.IDatabaseDbSystemDbSystemOptions? InternalValue
        {
            get => GetInstanceProperty<oci.DatabaseDbSystem.IDatabaseDbSystemDbSystemOptions?>();
            set => SetInstanceProperty(value);
        }
    }
}
