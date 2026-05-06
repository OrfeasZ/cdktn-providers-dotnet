using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.JmsTaskSchedule
{
    [JsiiClass(nativeType: typeof(oci.JmsTaskSchedule.JmsTaskScheduleTaskDetailsRemoveInstallationSiteTaskRequestOutputReference), fullyQualifiedName: "oci.jmsTaskSchedule.JmsTaskScheduleTaskDetailsRemoveInstallationSiteTaskRequestOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class JmsTaskScheduleTaskDetailsRemoveInstallationSiteTaskRequestOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public JmsTaskScheduleTaskDetailsRemoveInstallationSiteTaskRequestOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected JmsTaskScheduleTaskDetailsRemoveInstallationSiteTaskRequestOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected JmsTaskScheduleTaskDetailsRemoveInstallationSiteTaskRequestOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putInstallationSites", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.jmsTaskSchedule.JmsTaskScheduleTaskDetailsRemoveInstallationSiteTaskRequestInstallationSites\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutInstallationSites(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.JmsTaskSchedule.IJmsTaskScheduleTaskDetailsRemoveInstallationSiteTaskRequestInstallationSites[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.JmsTaskSchedule.IJmsTaskScheduleTaskDetailsRemoveInstallationSiteTaskRequestInstallationSites).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.JmsTaskSchedule.IJmsTaskScheduleTaskDetailsRemoveInstallationSiteTaskRequestInstallationSites).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetInstallationSites")]
        public virtual void ResetInstallationSites()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "installationSites", typeJson: "{\"fqn\":\"oci.jmsTaskSchedule.JmsTaskScheduleTaskDetailsRemoveInstallationSiteTaskRequestInstallationSitesList\"}")]
        public virtual oci.JmsTaskSchedule.JmsTaskScheduleTaskDetailsRemoveInstallationSiteTaskRequestInstallationSitesList InstallationSites
        {
            get => GetInstanceProperty<oci.JmsTaskSchedule.JmsTaskScheduleTaskDetailsRemoveInstallationSiteTaskRequestInstallationSitesList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "installationSitesInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.jmsTaskSchedule.JmsTaskScheduleTaskDetailsRemoveInstallationSiteTaskRequestInstallationSites\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? InstallationSitesInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.jmsTaskSchedule.JmsTaskScheduleTaskDetailsRemoveInstallationSiteTaskRequest\"}", isOptional: true)]
        public virtual oci.JmsTaskSchedule.IJmsTaskScheduleTaskDetailsRemoveInstallationSiteTaskRequest? InternalValue
        {
            get => GetInstanceProperty<oci.JmsTaskSchedule.IJmsTaskScheduleTaskDetailsRemoveInstallationSiteTaskRequest?>();
            set => SetInstanceProperty(value);
        }
    }
}
