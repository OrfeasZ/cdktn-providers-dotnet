using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.SynchronizationJobProvisionOnDemand
{
    [JsiiInterface(nativeType: typeof(ISynchronizationJobProvisionOnDemandParameterSubject), fullyQualifiedName: "azuread.synchronizationJobProvisionOnDemand.SynchronizationJobProvisionOnDemandParameterSubject")]
    public interface ISynchronizationJobProvisionOnDemandParameterSubject
    {
        /// <summary>The identifier of an object to which a synchronization job is to be applied.</summary>
        /// <remarks>
        /// Can be one of the following: (1) An onPremisesDistinguishedName for synchronization from Active Directory to Azure AD. (2) The user ID for synchronization from Azure AD to a third-party. (3) The Worker ID of the Workday worker for synchronization from Workday to either Active Directory or Azure AD.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/synchronization_job_provision_on_demand#object_id SynchronizationJobProvisionOnDemand#object_id}
        /// </remarks>
        [JsiiProperty(name: "objectId", typeJson: "{\"primitive\":\"string\"}")]
        string ObjectId
        {
            get;
        }

        /// <summary>The type of the object to which a synchronization job is to be applied.</summary>
        /// <remarks>
        /// Can be one of the following: <c>user</c> for synchronizing between Active Directory and Azure AD, <c>User</c> for synchronizing a user between Azure AD and a third-party application, <c>Worker</c> for synchronization a user between Workday and either Active Directory or Azure AD, <c>Group</c> for synchronizing a group between Azure AD and a third-party application.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/synchronization_job_provision_on_demand#object_type_name SynchronizationJobProvisionOnDemand#object_type_name}
        /// </remarks>
        [JsiiProperty(name: "objectTypeName", typeJson: "{\"primitive\":\"string\"}")]
        string ObjectTypeName
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISynchronizationJobProvisionOnDemandParameterSubject), fullyQualifiedName: "azuread.synchronizationJobProvisionOnDemand.SynchronizationJobProvisionOnDemandParameterSubject")]
        internal sealed class _Proxy : DeputyBase, azuread.SynchronizationJobProvisionOnDemand.ISynchronizationJobProvisionOnDemandParameterSubject
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The identifier of an object to which a synchronization job is to be applied.</summary>
            /// <remarks>
            /// Can be one of the following: (1) An onPremisesDistinguishedName for synchronization from Active Directory to Azure AD. (2) The user ID for synchronization from Azure AD to a third-party. (3) The Worker ID of the Workday worker for synchronization from Workday to either Active Directory or Azure AD.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/synchronization_job_provision_on_demand#object_id SynchronizationJobProvisionOnDemand#object_id}
            /// </remarks>
            [JsiiProperty(name: "objectId", typeJson: "{\"primitive\":\"string\"}")]
            public string ObjectId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The type of the object to which a synchronization job is to be applied.</summary>
            /// <remarks>
            /// Can be one of the following: <c>user</c> for synchronizing between Active Directory and Azure AD, <c>User</c> for synchronizing a user between Azure AD and a third-party application, <c>Worker</c> for synchronization a user between Workday and either Active Directory or Azure AD, <c>Group</c> for synchronizing a group between Azure AD and a third-party application.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/synchronization_job_provision_on_demand#object_type_name SynchronizationJobProvisionOnDemand#object_type_name}
            /// </remarks>
            [JsiiProperty(name: "objectTypeName", typeJson: "{\"primitive\":\"string\"}")]
            public string ObjectTypeName
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
