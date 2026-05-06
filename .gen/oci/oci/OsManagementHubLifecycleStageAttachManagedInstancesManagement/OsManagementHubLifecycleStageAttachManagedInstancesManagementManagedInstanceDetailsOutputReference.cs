using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OsManagementHubLifecycleStageAttachManagedInstancesManagement
{
    [JsiiClass(nativeType: typeof(oci.OsManagementHubLifecycleStageAttachManagedInstancesManagement.OsManagementHubLifecycleStageAttachManagedInstancesManagementManagedInstanceDetailsOutputReference), fullyQualifiedName: "oci.osManagementHubLifecycleStageAttachManagedInstancesManagement.OsManagementHubLifecycleStageAttachManagedInstancesManagementManagedInstanceDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class OsManagementHubLifecycleStageAttachManagedInstancesManagementManagedInstanceDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public OsManagementHubLifecycleStageAttachManagedInstancesManagementManagedInstanceDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected OsManagementHubLifecycleStageAttachManagedInstancesManagementManagedInstanceDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected OsManagementHubLifecycleStageAttachManagedInstancesManagementManagedInstanceDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putWorkRequestDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.osManagementHubLifecycleStageAttachManagedInstancesManagement.OsManagementHubLifecycleStageAttachManagedInstancesManagementManagedInstanceDetailsWorkRequestDetails\"}}]")]
        public virtual void PutWorkRequestDetails(oci.OsManagementHubLifecycleStageAttachManagedInstancesManagement.IOsManagementHubLifecycleStageAttachManagedInstancesManagementManagedInstanceDetailsWorkRequestDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.OsManagementHubLifecycleStageAttachManagedInstancesManagement.IOsManagementHubLifecycleStageAttachManagedInstancesManagementManagedInstanceDetailsWorkRequestDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetWorkRequestDetails")]
        public virtual void ResetWorkRequestDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "workRequestDetails", typeJson: "{\"fqn\":\"oci.osManagementHubLifecycleStageAttachManagedInstancesManagement.OsManagementHubLifecycleStageAttachManagedInstancesManagementManagedInstanceDetailsWorkRequestDetailsOutputReference\"}")]
        public virtual oci.OsManagementHubLifecycleStageAttachManagedInstancesManagement.OsManagementHubLifecycleStageAttachManagedInstancesManagementManagedInstanceDetailsWorkRequestDetailsOutputReference WorkRequestDetails
        {
            get => GetInstanceProperty<oci.OsManagementHubLifecycleStageAttachManagedInstancesManagement.OsManagementHubLifecycleStageAttachManagedInstancesManagementManagedInstanceDetailsWorkRequestDetailsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "managedInstancesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? ManagedInstancesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "workRequestDetailsInput", typeJson: "{\"fqn\":\"oci.osManagementHubLifecycleStageAttachManagedInstancesManagement.OsManagementHubLifecycleStageAttachManagedInstancesManagementManagedInstanceDetailsWorkRequestDetails\"}", isOptional: true)]
        public virtual oci.OsManagementHubLifecycleStageAttachManagedInstancesManagement.IOsManagementHubLifecycleStageAttachManagedInstancesManagementManagedInstanceDetailsWorkRequestDetails? WorkRequestDetailsInput
        {
            get => GetInstanceProperty<oci.OsManagementHubLifecycleStageAttachManagedInstancesManagement.IOsManagementHubLifecycleStageAttachManagedInstancesManagementManagedInstanceDetailsWorkRequestDetails?>();
        }

        [JsiiProperty(name: "managedInstances", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ManagedInstances
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.osManagementHubLifecycleStageAttachManagedInstancesManagement.OsManagementHubLifecycleStageAttachManagedInstancesManagementManagedInstanceDetails\"}", isOptional: true)]
        public virtual oci.OsManagementHubLifecycleStageAttachManagedInstancesManagement.IOsManagementHubLifecycleStageAttachManagedInstancesManagementManagedInstanceDetails? InternalValue
        {
            get => GetInstanceProperty<oci.OsManagementHubLifecycleStageAttachManagedInstancesManagement.IOsManagementHubLifecycleStageAttachManagedInstancesManagementManagedInstanceDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
