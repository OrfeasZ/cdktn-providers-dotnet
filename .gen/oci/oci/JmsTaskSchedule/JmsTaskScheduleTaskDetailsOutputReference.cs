using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.JmsTaskSchedule
{
    [JsiiClass(nativeType: typeof(oci.JmsTaskSchedule.JmsTaskScheduleTaskDetailsOutputReference), fullyQualifiedName: "oci.jmsTaskSchedule.JmsTaskScheduleTaskDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class JmsTaskScheduleTaskDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public JmsTaskScheduleTaskDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected JmsTaskScheduleTaskDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected JmsTaskScheduleTaskDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAddInstallationSiteTaskRequest", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.jmsTaskSchedule.JmsTaskScheduleTaskDetailsAddInstallationSiteTaskRequest\"}}]")]
        public virtual void PutAddInstallationSiteTaskRequest(oci.JmsTaskSchedule.IJmsTaskScheduleTaskDetailsAddInstallationSiteTaskRequest @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.JmsTaskSchedule.IJmsTaskScheduleTaskDetailsAddInstallationSiteTaskRequest)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCryptoTaskRequest", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.jmsTaskSchedule.JmsTaskScheduleTaskDetailsCryptoTaskRequest\"}}]")]
        public virtual void PutCryptoTaskRequest(oci.JmsTaskSchedule.IJmsTaskScheduleTaskDetailsCryptoTaskRequest @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.JmsTaskSchedule.IJmsTaskScheduleTaskDetailsCryptoTaskRequest)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDeployedApplicationMigrationTaskRequest", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.jmsTaskSchedule.JmsTaskScheduleTaskDetailsDeployedApplicationMigrationTaskRequest\"}}]")]
        public virtual void PutDeployedApplicationMigrationTaskRequest(oci.JmsTaskSchedule.IJmsTaskScheduleTaskDetailsDeployedApplicationMigrationTaskRequest @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.JmsTaskSchedule.IJmsTaskScheduleTaskDetailsDeployedApplicationMigrationTaskRequest)}, new object[]{@value});
        }

        [JsiiMethod(name: "putJavaMigrationTaskRequest", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.jmsTaskSchedule.JmsTaskScheduleTaskDetailsJavaMigrationTaskRequest\"}}]")]
        public virtual void PutJavaMigrationTaskRequest(oci.JmsTaskSchedule.IJmsTaskScheduleTaskDetailsJavaMigrationTaskRequest @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.JmsTaskSchedule.IJmsTaskScheduleTaskDetailsJavaMigrationTaskRequest)}, new object[]{@value});
        }

        [JsiiMethod(name: "putJfrTaskRequest", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.jmsTaskSchedule.JmsTaskScheduleTaskDetailsJfrTaskRequest\"}}]")]
        public virtual void PutJfrTaskRequest(oci.JmsTaskSchedule.IJmsTaskScheduleTaskDetailsJfrTaskRequest @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.JmsTaskSchedule.IJmsTaskScheduleTaskDetailsJfrTaskRequest)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPerformanceTuningTaskRequest", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.jmsTaskSchedule.JmsTaskScheduleTaskDetailsPerformanceTuningTaskRequest\"}}]")]
        public virtual void PutPerformanceTuningTaskRequest(oci.JmsTaskSchedule.IJmsTaskScheduleTaskDetailsPerformanceTuningTaskRequest @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.JmsTaskSchedule.IJmsTaskScheduleTaskDetailsPerformanceTuningTaskRequest)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRemoveInstallationSiteTaskRequest", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.jmsTaskSchedule.JmsTaskScheduleTaskDetailsRemoveInstallationSiteTaskRequest\"}}]")]
        public virtual void PutRemoveInstallationSiteTaskRequest(oci.JmsTaskSchedule.IJmsTaskScheduleTaskDetailsRemoveInstallationSiteTaskRequest @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.JmsTaskSchedule.IJmsTaskScheduleTaskDetailsRemoveInstallationSiteTaskRequest)}, new object[]{@value});
        }

        [JsiiMethod(name: "putScanJavaServerTaskRequest", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.jmsTaskSchedule.JmsTaskScheduleTaskDetailsScanJavaServerTaskRequest\"}}]")]
        public virtual void PutScanJavaServerTaskRequest(oci.JmsTaskSchedule.IJmsTaskScheduleTaskDetailsScanJavaServerTaskRequest @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.JmsTaskSchedule.IJmsTaskScheduleTaskDetailsScanJavaServerTaskRequest)}, new object[]{@value});
        }

        [JsiiMethod(name: "putScanLibraryTaskRequest", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.jmsTaskSchedule.JmsTaskScheduleTaskDetailsScanLibraryTaskRequest\"}}]")]
        public virtual void PutScanLibraryTaskRequest(oci.JmsTaskSchedule.IJmsTaskScheduleTaskDetailsScanLibraryTaskRequest @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.JmsTaskSchedule.IJmsTaskScheduleTaskDetailsScanLibraryTaskRequest)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAddInstallationSiteTaskRequest")]
        public virtual void ResetAddInstallationSiteTaskRequest()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCryptoTaskRequest")]
        public virtual void ResetCryptoTaskRequest()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDeployedApplicationMigrationTaskRequest")]
        public virtual void ResetDeployedApplicationMigrationTaskRequest()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetJavaMigrationTaskRequest")]
        public virtual void ResetJavaMigrationTaskRequest()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetJfrTaskRequest")]
        public virtual void ResetJfrTaskRequest()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPerformanceTuningTaskRequest")]
        public virtual void ResetPerformanceTuningTaskRequest()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRemoveInstallationSiteTaskRequest")]
        public virtual void ResetRemoveInstallationSiteTaskRequest()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetScanJavaServerTaskRequest")]
        public virtual void ResetScanJavaServerTaskRequest()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetScanLibraryTaskRequest")]
        public virtual void ResetScanLibraryTaskRequest()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "addInstallationSiteTaskRequest", typeJson: "{\"fqn\":\"oci.jmsTaskSchedule.JmsTaskScheduleTaskDetailsAddInstallationSiteTaskRequestOutputReference\"}")]
        public virtual oci.JmsTaskSchedule.JmsTaskScheduleTaskDetailsAddInstallationSiteTaskRequestOutputReference AddInstallationSiteTaskRequest
        {
            get => GetInstanceProperty<oci.JmsTaskSchedule.JmsTaskScheduleTaskDetailsAddInstallationSiteTaskRequestOutputReference>()!;
        }

        [JsiiProperty(name: "cryptoTaskRequest", typeJson: "{\"fqn\":\"oci.jmsTaskSchedule.JmsTaskScheduleTaskDetailsCryptoTaskRequestOutputReference\"}")]
        public virtual oci.JmsTaskSchedule.JmsTaskScheduleTaskDetailsCryptoTaskRequestOutputReference CryptoTaskRequest
        {
            get => GetInstanceProperty<oci.JmsTaskSchedule.JmsTaskScheduleTaskDetailsCryptoTaskRequestOutputReference>()!;
        }

        [JsiiProperty(name: "deployedApplicationMigrationTaskRequest", typeJson: "{\"fqn\":\"oci.jmsTaskSchedule.JmsTaskScheduleTaskDetailsDeployedApplicationMigrationTaskRequestOutputReference\"}")]
        public virtual oci.JmsTaskSchedule.JmsTaskScheduleTaskDetailsDeployedApplicationMigrationTaskRequestOutputReference DeployedApplicationMigrationTaskRequest
        {
            get => GetInstanceProperty<oci.JmsTaskSchedule.JmsTaskScheduleTaskDetailsDeployedApplicationMigrationTaskRequestOutputReference>()!;
        }

        [JsiiProperty(name: "javaMigrationTaskRequest", typeJson: "{\"fqn\":\"oci.jmsTaskSchedule.JmsTaskScheduleTaskDetailsJavaMigrationTaskRequestOutputReference\"}")]
        public virtual oci.JmsTaskSchedule.JmsTaskScheduleTaskDetailsJavaMigrationTaskRequestOutputReference JavaMigrationTaskRequest
        {
            get => GetInstanceProperty<oci.JmsTaskSchedule.JmsTaskScheduleTaskDetailsJavaMigrationTaskRequestOutputReference>()!;
        }

        [JsiiProperty(name: "jfrTaskRequest", typeJson: "{\"fqn\":\"oci.jmsTaskSchedule.JmsTaskScheduleTaskDetailsJfrTaskRequestOutputReference\"}")]
        public virtual oci.JmsTaskSchedule.JmsTaskScheduleTaskDetailsJfrTaskRequestOutputReference JfrTaskRequest
        {
            get => GetInstanceProperty<oci.JmsTaskSchedule.JmsTaskScheduleTaskDetailsJfrTaskRequestOutputReference>()!;
        }

        [JsiiProperty(name: "performanceTuningTaskRequest", typeJson: "{\"fqn\":\"oci.jmsTaskSchedule.JmsTaskScheduleTaskDetailsPerformanceTuningTaskRequestOutputReference\"}")]
        public virtual oci.JmsTaskSchedule.JmsTaskScheduleTaskDetailsPerformanceTuningTaskRequestOutputReference PerformanceTuningTaskRequest
        {
            get => GetInstanceProperty<oci.JmsTaskSchedule.JmsTaskScheduleTaskDetailsPerformanceTuningTaskRequestOutputReference>()!;
        }

        [JsiiProperty(name: "removeInstallationSiteTaskRequest", typeJson: "{\"fqn\":\"oci.jmsTaskSchedule.JmsTaskScheduleTaskDetailsRemoveInstallationSiteTaskRequestOutputReference\"}")]
        public virtual oci.JmsTaskSchedule.JmsTaskScheduleTaskDetailsRemoveInstallationSiteTaskRequestOutputReference RemoveInstallationSiteTaskRequest
        {
            get => GetInstanceProperty<oci.JmsTaskSchedule.JmsTaskScheduleTaskDetailsRemoveInstallationSiteTaskRequestOutputReference>()!;
        }

        [JsiiProperty(name: "scanJavaServerTaskRequest", typeJson: "{\"fqn\":\"oci.jmsTaskSchedule.JmsTaskScheduleTaskDetailsScanJavaServerTaskRequestOutputReference\"}")]
        public virtual oci.JmsTaskSchedule.JmsTaskScheduleTaskDetailsScanJavaServerTaskRequestOutputReference ScanJavaServerTaskRequest
        {
            get => GetInstanceProperty<oci.JmsTaskSchedule.JmsTaskScheduleTaskDetailsScanJavaServerTaskRequestOutputReference>()!;
        }

        [JsiiProperty(name: "scanLibraryTaskRequest", typeJson: "{\"fqn\":\"oci.jmsTaskSchedule.JmsTaskScheduleTaskDetailsScanLibraryTaskRequestOutputReference\"}")]
        public virtual oci.JmsTaskSchedule.JmsTaskScheduleTaskDetailsScanLibraryTaskRequestOutputReference ScanLibraryTaskRequest
        {
            get => GetInstanceProperty<oci.JmsTaskSchedule.JmsTaskScheduleTaskDetailsScanLibraryTaskRequestOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "addInstallationSiteTaskRequestInput", typeJson: "{\"fqn\":\"oci.jmsTaskSchedule.JmsTaskScheduleTaskDetailsAddInstallationSiteTaskRequest\"}", isOptional: true)]
        public virtual oci.JmsTaskSchedule.IJmsTaskScheduleTaskDetailsAddInstallationSiteTaskRequest? AddInstallationSiteTaskRequestInput
        {
            get => GetInstanceProperty<oci.JmsTaskSchedule.IJmsTaskScheduleTaskDetailsAddInstallationSiteTaskRequest?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "cryptoTaskRequestInput", typeJson: "{\"fqn\":\"oci.jmsTaskSchedule.JmsTaskScheduleTaskDetailsCryptoTaskRequest\"}", isOptional: true)]
        public virtual oci.JmsTaskSchedule.IJmsTaskScheduleTaskDetailsCryptoTaskRequest? CryptoTaskRequestInput
        {
            get => GetInstanceProperty<oci.JmsTaskSchedule.IJmsTaskScheduleTaskDetailsCryptoTaskRequest?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "deployedApplicationMigrationTaskRequestInput", typeJson: "{\"fqn\":\"oci.jmsTaskSchedule.JmsTaskScheduleTaskDetailsDeployedApplicationMigrationTaskRequest\"}", isOptional: true)]
        public virtual oci.JmsTaskSchedule.IJmsTaskScheduleTaskDetailsDeployedApplicationMigrationTaskRequest? DeployedApplicationMigrationTaskRequestInput
        {
            get => GetInstanceProperty<oci.JmsTaskSchedule.IJmsTaskScheduleTaskDetailsDeployedApplicationMigrationTaskRequest?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "javaMigrationTaskRequestInput", typeJson: "{\"fqn\":\"oci.jmsTaskSchedule.JmsTaskScheduleTaskDetailsJavaMigrationTaskRequest\"}", isOptional: true)]
        public virtual oci.JmsTaskSchedule.IJmsTaskScheduleTaskDetailsJavaMigrationTaskRequest? JavaMigrationTaskRequestInput
        {
            get => GetInstanceProperty<oci.JmsTaskSchedule.IJmsTaskScheduleTaskDetailsJavaMigrationTaskRequest?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "jfrTaskRequestInput", typeJson: "{\"fqn\":\"oci.jmsTaskSchedule.JmsTaskScheduleTaskDetailsJfrTaskRequest\"}", isOptional: true)]
        public virtual oci.JmsTaskSchedule.IJmsTaskScheduleTaskDetailsJfrTaskRequest? JfrTaskRequestInput
        {
            get => GetInstanceProperty<oci.JmsTaskSchedule.IJmsTaskScheduleTaskDetailsJfrTaskRequest?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "performanceTuningTaskRequestInput", typeJson: "{\"fqn\":\"oci.jmsTaskSchedule.JmsTaskScheduleTaskDetailsPerformanceTuningTaskRequest\"}", isOptional: true)]
        public virtual oci.JmsTaskSchedule.IJmsTaskScheduleTaskDetailsPerformanceTuningTaskRequest? PerformanceTuningTaskRequestInput
        {
            get => GetInstanceProperty<oci.JmsTaskSchedule.IJmsTaskScheduleTaskDetailsPerformanceTuningTaskRequest?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "removeInstallationSiteTaskRequestInput", typeJson: "{\"fqn\":\"oci.jmsTaskSchedule.JmsTaskScheduleTaskDetailsRemoveInstallationSiteTaskRequest\"}", isOptional: true)]
        public virtual oci.JmsTaskSchedule.IJmsTaskScheduleTaskDetailsRemoveInstallationSiteTaskRequest? RemoveInstallationSiteTaskRequestInput
        {
            get => GetInstanceProperty<oci.JmsTaskSchedule.IJmsTaskScheduleTaskDetailsRemoveInstallationSiteTaskRequest?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "scanJavaServerTaskRequestInput", typeJson: "{\"fqn\":\"oci.jmsTaskSchedule.JmsTaskScheduleTaskDetailsScanJavaServerTaskRequest\"}", isOptional: true)]
        public virtual oci.JmsTaskSchedule.IJmsTaskScheduleTaskDetailsScanJavaServerTaskRequest? ScanJavaServerTaskRequestInput
        {
            get => GetInstanceProperty<oci.JmsTaskSchedule.IJmsTaskScheduleTaskDetailsScanJavaServerTaskRequest?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "scanLibraryTaskRequestInput", typeJson: "{\"fqn\":\"oci.jmsTaskSchedule.JmsTaskScheduleTaskDetailsScanLibraryTaskRequest\"}", isOptional: true)]
        public virtual oci.JmsTaskSchedule.IJmsTaskScheduleTaskDetailsScanLibraryTaskRequest? ScanLibraryTaskRequestInput
        {
            get => GetInstanceProperty<oci.JmsTaskSchedule.IJmsTaskScheduleTaskDetailsScanLibraryTaskRequest?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "taskTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TaskTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "taskType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TaskType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.jmsTaskSchedule.JmsTaskScheduleTaskDetails\"}", isOptional: true)]
        public virtual oci.JmsTaskSchedule.IJmsTaskScheduleTaskDetails? InternalValue
        {
            get => GetInstanceProperty<oci.JmsTaskSchedule.IJmsTaskScheduleTaskDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
