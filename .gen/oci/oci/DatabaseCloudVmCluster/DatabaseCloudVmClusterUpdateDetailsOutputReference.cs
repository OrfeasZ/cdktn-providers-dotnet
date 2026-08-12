using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseCloudVmCluster
{
    [JsiiClass(nativeType: typeof(oci.DatabaseCloudVmCluster.DatabaseCloudVmClusterUpdateDetailsOutputReference), fullyQualifiedName: "oci.databaseCloudVmCluster.DatabaseCloudVmClusterUpdateDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DatabaseCloudVmClusterUpdateDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DatabaseCloudVmClusterUpdateDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DatabaseCloudVmClusterUpdateDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatabaseCloudVmClusterUpdateDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetUpdateAction")]
        public virtual void ResetUpdateAction()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUpdateId")]
        public virtual void ResetUpdateId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUpdateMode")]
        public virtual void ResetUpdateMode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "updateActionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UpdateActionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "updateIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UpdateIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "updateModeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UpdateModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "updateAction", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UpdateAction
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "updateId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UpdateId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "updateMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UpdateMode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.databaseCloudVmCluster.DatabaseCloudVmClusterUpdateDetails\"}", isOptional: true)]
        public virtual oci.DatabaseCloudVmCluster.IDatabaseCloudVmClusterUpdateDetails? InternalValue
        {
            get => GetInstanceProperty<oci.DatabaseCloudVmCluster.IDatabaseCloudVmClusterUpdateDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
