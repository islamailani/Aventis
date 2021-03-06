export class SearchBoxModel implements ISearchBoxModel {
    ID: any | undefined;
    Name: any;
    GroupName: any;
    IconNameDX?: any;
    IconSrc?: any;

    constructor(data?: ISearchBoxModel) {
        if (data) {
            for (var property in data) {
                if (data.hasOwnProperty(property))
                    (<any>this)[property] = (<any>data)[property];
            }
        }
    }
}

export interface ISearchBoxModel {
    ID: any | undefined;
    Name: any;
    GroupName: any;
    IconNameDX?: any;
    IconSrc?: any;
}
