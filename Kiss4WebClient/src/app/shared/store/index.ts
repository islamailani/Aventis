import { createSelector } from 'reselect';

/**
 * More info: https://egghead.io/lessons/javascript-redux-implementing-combinereducers-from-scratch
 */
import { ActionReducer, combineReducers } from '@ngrx/store';

/**
 * More info: https://drboolean.gitbooks.io/mostly-adequate-guide/content/ch5.html
 */
import { compose } from '@ngrx/core/compose';

/**
 * Every reducer module's default export is the reducer function itself. In
 * addition, each module should export a type or interface that describes
 * the state of the reducer plus any selector functions. The `* as`
 * notation packages up all of the exports into a single object.
 */
import * as fromSettings from './reducers/settings.reducer';
import * as fromAuth from './reducers/auth.reducer';
import * as fromPersons from './reducers/persons.reducer';
import * as fromPersonDetails from './reducers/person-details.reducer';
import * as fromMenus from './reducers/menus.reducer';
import * as fromSearchBoxData from './reducers/search-box.reducer';
import * as fromDossiersData from './reducers/dossier.reducer';
import * as fromPendenzen from './reducers/pendenzen.reducer';

/**
 * We treat each reducer like a table in a database. This means
 * our top level state interface is just a map of keys to inner state types.
 */
export interface State {
  settings: fromSettings.State;
  login: fromAuth.State;
  persons: fromPersons.State;
  personDetails: fromPersonDetails.State;
  menus: fromMenus.State;
  searchBoxDatas: fromSearchBoxData.State;
  dossierDatas: fromDossiersData.State;
  fromPendenzen: fromPendenzen.State;
}

/**
 * Because metareducers take a reducer function and return a new reducer,
 * we can use our compose helper to chain them together. Here we are
 * using combineReducers to make our top level reducer, and then
 * wrapping that in storeLogger. Remember that compose applies
 * the result from right to left.
 */
export const reducers = {
  settings: fromSettings.reducer,
  login: fromAuth.reducer,
  persons: fromPersons.reducer,
  personDetails: fromPersonDetails.reducer,
  menus: fromMenus.reducer,
  searchBoxDatas: fromSearchBoxData.reducer,
  dossierDatas: fromDossiersData.reducer,
  fromPendenzen: fromPendenzen.reducer
};

export function store(state: any, action: any) {
  const store: ActionReducer<State> = compose(combineReducers)(reducers);
  return store(state, action);
}

/**
 * Every reducer module exports selector functions, however child reducers
 * have no knowledge of the overall state tree. To make them useable, we
 * need to make new selectors that wrap them.
 */

/**
 * Settings store functions
 */
export const getSettingsState = (state: State) => state.settings;
export const getSelectedLanguage = createSelector(getSettingsState, fromSettings.getSelectedLanguage);
export const getSelectedCulture = createSelector(getSettingsState, fromSettings.getSelectedCulture);
export const getAvailableLanguages = createSelector(getSettingsState, fromSettings.getAvailableLanguages);
export const getAvailableRoles = createSelector(getSettingsState, fromSettings.getAvailableRoles);
export const getSelectedActions = createSelector(getSettingsState, fromSettings.getSelectedActions);
export const getXDocumentCreate = createSelector(getSettingsState, fromSettings.getXDocumentCreate);
export const getDocumentCreateObject = createSelector(getSettingsState, fromSettings.getDocumentCreateObject);
/**
 * Auth store functions
 */
export const getAuthState = (state: State) => state.login;
export const getAuthLoaded = createSelector(getAuthState, fromAuth.getLoaded);
export const getAuthLoading = createSelector(getAuthState, fromAuth.getLoading);
export const getAuthFailed = createSelector(getAuthState, fromAuth.getFailed);
export const getLoggedUser = createSelector(getAuthState, fromAuth.getLoggedUser);

/**
 * Persons store functions
 */
export const getPersonsState = (state: State) => state.persons;
export const getPersonsLoaded = createSelector(getPersonsState, fromPersons.getLoaded);
export const getPersonsLoading = createSelector(getPersonsState, fromPersons.getLoading);
export const getPersonsFailed = createSelector(getPersonsState, fromPersons.getFailed);
export const getPersonsData = createSelector(getPersonsState, fromPersons.getData);
export const getPersonAddNew = createSelector(getPersonsState, fromPersons.getPerson);
export const getStatusAdding = createSelector(getPersonsState, fromPersons.getAdding);

/**
  * Person details store functions
  */
export const getPersonDetailsState = (state: State) => state.personDetails;
export const getPersonDetailsLoaded = createSelector(getPersonDetailsState, fromPersonDetails.getLoaded);
export const getPersonDetailsLoading = createSelector(getPersonDetailsState, fromPersonDetails.getLoading);
export const getPersonDetailsFailed = createSelector(getPersonDetailsState, fromPersonDetails.getFailed);
export const getPersonDetailsData = createSelector(getPersonDetailsState, fromPersonDetails.getData);

/**
 * Menus store functions
 */
export const getMenusState = (state: State) => state.menus;
export const getMenusLoaded = createSelector(getMenusState, fromMenus.getLoaded);
export const getMenusLoading = createSelector(getMenusState, fromMenus.getLoading);
export const getMenusFailed = createSelector(getMenusState, fromMenus.getFailed);
export const getMenusData = createSelector(getMenusState, fromMenus.getData);
export const getSelectMenu = createSelector(getMenusState, fromMenus.getSelectItem);
export const getAvaiableMenus = createSelector(getMenusState, fromMenus.getAvaiableMenus);
/**
 * search box data store functions
 */
export const getSearchBoxDatasState = (state: State) => state.searchBoxDatas;
export const getSearchBoxDatasLoaded = createSelector(getSearchBoxDatasState, fromSearchBoxData.getLoaded);
export const getSearchBoxDatasLoading = createSelector(getSearchBoxDatasState, fromSearchBoxData.getLoading);
export const getSearchBoxDatasFailed = createSelector(getSearchBoxDatasState, fromSearchBoxData.getFailed);
export const getSearchBoxDatasData = createSelector(getSearchBoxDatasState, fromSearchBoxData.getData);

/**
 * get Trees Dossier Navigator
 *
 */
export const getDossierTreeDataState = (state: State) => state.dossierDatas;
export const getDossierTreesLoaded = createSelector(getDossierTreeDataState, fromDossiersData.getLoaded);
export const getDossierTreesLoading = createSelector(getDossierTreeDataState, fromDossiersData.getLoading);
export const getDossierTreesFailed = createSelector(getDossierTreeDataState, fromDossiersData.getFailed);
export const getDossierTreesData = createSelector(getDossierTreeDataState, fromDossiersData.getTrees);
export const getFiltersDossier = createSelector(getDossierTreeDataState, fromDossiersData.getFilters);
export const getTreeDetail = createSelector(getDossierTreeDataState, fromDossiersData.getTreeDetail);

/**
 * Pendenzen Stores function
 */
export const getPendenzenState = (state: State) => state.fromPendenzen;
export const getPendenzenData = createSelector(
  getPendenzenState,
  fromPendenzen.getData
);
export const getPendenzenDetail = createSelector(
  getPendenzenState,
  fromPendenzen.getDetail
);
export const getNavBarItems = createSelector(
  getPendenzenState,
  fromPendenzen.getNavBarItems
);
export const processTask = createSelector(
  getPendenzenState,
  fromPendenzen.processTask
);
export const searchOptionPendenzen = createSelector(
  getPendenzenState,
  fromPendenzen.getData
);
export const getErsteller = createSelector(
  getPendenzenState,
  fromPendenzen.getErsteller
);
export const getPendenzenLoading = createSelector(
  getPendenzenState,
  fromPendenzen.getLoading
);
export const getPendenzenLoaded = createSelector(
  getPendenzenState,
  fromPendenzen.getLoaded
);
export const getPendenzenFailed = createSelector(
  getPendenzenState,
  fromPendenzen.getFailed
);
export const loadMasterData = createSelector(
  getPendenzenState,
  fromPendenzen.loadMasterData
);
export const getEmpfanger = createSelector(
  getPendenzenState,
  fromPendenzen.getEmpfanger
);
export const getLeistungsverantw = createSelector(
  getPendenzenState,
  fromPendenzen.getLeistungsverantw
);
export const getFalltrager = createSelector(
  getPendenzenState,
  fromPendenzen.getFalltrager
);
export const getLeistungPerson = createSelector(
  getPendenzenState,
  fromPendenzen.getLeistungPerson
);
export const updateTask = createSelector(
  getPendenzenState,
  fromPendenzen.updateTask
);
export const getDataSearch = createSelector(
  getPendenzenState,
  fromPendenzen.getDataSearch
);
export const getLeistungsverantwCreate = createSelector(
  getPendenzenState,
  fromPendenzen.getLeistungsverantwCreate
);
